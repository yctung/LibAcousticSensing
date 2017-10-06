//
//  SettingTableViewController.m
//  DevApp
//
//  Created by Yu-Chih on 10/1/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "SettingTableViewController.h"
#import "AppConstant.h"

@interface SettingTableViewController ()
    
@end

@implementation SettingTableViewController
//@synthesize tableView;

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil {
    if ((self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil])) {
        // TODO: init preference
        [self setTitle:@"Sening Setting"];
        
        debugStatus = [[NSMutableString alloc] init];
        ass = [[AcousticSensingSetting alloc] initWithEditorDelegate:self];
        asc = [[AcousticSensingController alloc] initWithCaller:self];
        
        modeSegmentControl = [[UISegmentedControl alloc] initWithItems:[NSArray arrayWithObjects:LIBAS_SETTING_MODE_REMOTE, LIBAS_SETTING_MODE_STANDALONE, nil]];
        [modeSegmentControl setFrame:CGRectMake(0, 0, 200, 30)];
        [modeSegmentControl addTarget:self action:@selector(modeChanged) forControlEvents:UIControlEventValueChanged];
        
        micSegmentControl = [[UISegmentedControl alloc] initWithItems:[NSArray arrayWithObjects:LIBAS_SETTING_RECORDER_MIC_BACK, LIBAS_SETTING_RECORDER_MIC_FRONT, LIBAS_SETTING_RECORDER_MIC_BOTTOM, nil]];
        [micSegmentControl setFrame:CGRectMake(0, 0, 250, 30)];
        [micSegmentControl addTarget:self action:@selector(micChanged) forControlEvents:UIControlEventValueChanged];
        
        speakerSegmentControl = [[UISegmentedControl alloc] initWithItems:[NSArray arrayWithObjects:LIBAS_SETTING_PLAY_SPEAKER_TOP, LIBAS_SETTING_PLAY_SPEAKER_BOTTOM, nil]];
        [speakerSegmentControl setFrame:CGRectMake(0, 0, 200, 30)];
        [speakerSegmentControl addTarget:self action:@selector(speakerChanged) forControlEvents:UIControlEventValueChanged];
    }
    return self;
}

- (void)viewDidLoad {
    [super viewDidLoad];
    
    // Uncomment the following line to preserve selection between presentations.
    // self.clearsSelectionOnViewWillAppear = NO;
    
    // Uncomment the following line to display an Edit button in the navigation bar for this view controller.
    // self.navigationItem.rightBarButtonItem = self.editButtonItem;
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}



// data source management
- (CellTagType)whichCellTagInSection: (NSInteger)section andRow: (NSInteger)row {
    switch (section) {
        case 0: // mode + server section
            switch (row) {
                case 0:
                    return CellTagMode;
                case 1:
                    return CellTagServerAddress;
                case 2:
                    return CellTagServerPort;
                default:
                    break;
            }
            break;
        case 1: // audio section
            switch (row) {
                case 0:
                    return CellTagMicSource;
                case 1:
                    return CellTagSpeakerSource;
                default:
                    break;
            }
            break;
        case 2: // action section
            switch (row) {
                case 0:
                    return CellTagResetToDefault;
                case 1:
                    return CellTagStart;
                default:
                    break;
            }
            break;
        case 3: // debug section
            switch (row) {
                case 0:
                    return CellTagDebug;
                    break;
                default:
                    break;
            }
            break;
        default:
            break;
    }
    // not found
    return CellTagUndefined;
}

- (CellTagType)whichCellTag: (NSIndexPath *)indexPath {
    NSInteger section = indexPath.section;
    NSInteger row = indexPath.row;
    return [self whichCellTagInSection:section andRow:row];
}


#pragma mark - Table view data source

- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView {
    return 4;
}

- (NSString *)tableView: (UITableView *)tableView titleForHeaderInSection:(NSInteger) section {
    switch (section) {
        case 0:
            return @"Mode";
        case 1:
            return @"Audio";
        case 2:
            return @"Action";
        case 3:
            return @"Status";
        default:
            return nil;
            break;
    }
}

- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section {
    if (section == 0) { // server section
        return 4;
    } else if (section == 1) { // audio section
        return 2;
    } else if (section == 2) { // action section
        return 2;
    } else if (section == 3) { // status section
        return 1;
    }
    //NSLog(@"[WARN]: undefined section number = %ld", (long)section);
    return 0;
}


- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    static NSString *cellIdSetting = @"CellIdSetting";
    static NSString *cellIdAction = @"CellIdAction";
    
    //UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:cellId forIndexPath:indexPath];
    // we should use the shorter version of this dequeue method to avoid the error of
    // "unable to dequeue a cell with identifier Cell - must register a nib or a class for the identifier"
    // ref: https://stackoverflow.com/questions/23526756/unable-to-dequeue-a-cell-with-identifier-cell-must-register-a-nib-or-a-class-f
    //UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:cellId];
    
    // Configure the cell...
    //if (cell == nil) {
        //cell = [[[UITableViewCell alloc] initWithStyle:UITableViewCellStyleValue1 reuseIdentifier:cellId] autorelease];
        //cell.selectionStyle = UITableViewCellSelectionStyleNone;
        //cell = [[[UITableViewCell alloc] initWithStyle:UITableViewCellStyleDefault reuseIdentifier:cellId] autorelease];
    //}
    
    
    UITableViewCell *cell;
    CellTagType tag = [self whichCellTag:indexPath];
    
    if (tag == CellTagResetToDefault || tag == CellTagStart) { //  action cells
        cell = [tableView dequeueReusableCellWithIdentifier:cellIdAction];
        if (cell == nil) {
            // NOTE: only UITableViewCellStyleDefault can make the text in the center
            cell = [[[UITableViewCell alloc] initWithStyle:UITableViewCellStyleDefault reuseIdentifier:cellIdAction] autorelease];
            cell.selectionStyle = UITableViewCellSelectionStyleNone;
            cell.textLabel.textAlignment = NSTextAlignmentCenter;
        }
    } else { //  setting cells
        cell = [tableView dequeueReusableCellWithIdentifier:cellIdSetting];
        if (cell == nil) {
            cell = [[[UITableViewCell alloc] initWithStyle:UITableViewCellStyleValue1 reuseIdentifier:cellIdSetting] autorelease];
            cell.selectionStyle = UITableViewCellSelectionStyleNone;
        }
        cell.detailTextLabel.text = nil;
        cell.accessoryView = nil;
    }
    
    switch (tag) {
        // ---------------
        //  setting cells
        // ---------------
        case CellTagMode:
            cell.textLabel.text = @"Mode";
            cell.accessoryView = modeSegmentControl;
            if ([[ass getMode] isEqualToString:LIBAS_SETTING_MODE_REMOTE]) {
                [modeSegmentControl setSelectedSegmentIndex:0];
            } else if ([[ass getMode] isEqualToString:LIBAS_SETTING_MODE_STANDALONE]) {
                [modeSegmentControl setSelectedSegmentIndex:1];
            }
            break;
        case CellTagServerAddress:
            cell.textLabel.text = @"Server IP";
            cell.detailTextLabel.text = [ass getServerAddress];
            break;
        case CellTagServerPort:
            cell.textLabel.text = @"Server Port";
            cell.detailTextLabel.text = [ass getServerPort];
            break;
        case CellTagMicSource: {
            cell.textLabel.text = @"Mic";
            cell.accessoryView = micSegmentControl;
            // TODO: try to get index directly from the array of titles in the micSegmentControl (so more robust even when we change the name)
            NSString *mic = [ass getRecorderMic];
            if ([mic isEqualToString:LIBAS_SETTING_RECORDER_MIC_BACK]) {
                [micSegmentControl setSelectedSegmentIndex:0];
            } else if ([mic isEqualToString:LIBAS_SETTING_RECORDER_MIC_FRONT]) {
                [micSegmentControl setSelectedSegmentIndex:1];
            } else if ([mic isEqualToString:LIBAS_SETTING_RECORDER_MIC_BOTTOM]) {
                [micSegmentControl setSelectedSegmentIndex:2];
            } else {
                NSLog(@"[ERROR]: undefined mic = %@", mic);
            }
            break;
        }
        case CellTagSpeakerSource: {
            cell.textLabel.text = @"Speaker";
            cell.accessoryView = speakerSegmentControl;
            // TODO: try to get index directly from the array of titles in the micSegmentControl (so more robust even when we change the name)
            NSString *speaker = [ass getPlaySpeaker];
            if ([speaker isEqualToString:LIBAS_SETTING_PLAY_SPEAKER_TOP]) {
                [speakerSegmentControl setSelectedSegmentIndex:0];
            } else if ([speaker isEqualToString:LIBAS_SETTING_PLAY_SPEAKER_BOTTOM]) {
                [speakerSegmentControl setSelectedSegmentIndex:1];
            } else {
                NSLog(@"[ERROR]: undefined speaker = %@", speaker);
            }
            break;
        }
        // ---------------
        //  action cells
        // ---------------
        case CellTagResetToDefault:
            cell.textLabel.text = @"Reset Setting";
            break;
        case CellTagStart:
            cell.textLabel.text = @"Start";
            break;
        // ---------------
        //  status cells
        // ---------------
        case CellTagDebug:
            cell.textLabel.text = debugStatus;
            break;
        default:
            cell.textLabel.text = @"Undefined";
            break;
    }
    
    return cell;
}

/*
// Override to support conditional editing of the table view.
- (BOOL)tableView:(UITableView *)tableView canEditRowAtIndexPath:(NSIndexPath *)indexPath {
    // Return NO if you do not want the specified item to be editable.
    return YES;
}
*/

/*
// Override to support editing the table view.
- (void)tableView:(UITableView *)tableView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndexPath:(NSIndexPath *)indexPath {
    if (editingStyle == UITableViewCellEditingStyleDelete) {
        // Delete the row from the data source
        [tableView deleteRowsAtIndexPaths:@[indexPath] withRowAnimation:UITableViewRowAnimationFade];
    } else if (editingStyle == UITableViewCellEditingStyleInsert) {
        // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view
    }   
}
*/

/*
// Override to support rearranging the table view.
- (void)tableView:(UITableView *)tableView moveRowAtIndexPath:(NSIndexPath *)fromIndexPath toIndexPath:(NSIndexPath *)toIndexPath {
}
*/

/*
// Override to support conditional rearranging of the table view.
- (BOOL)tableView:(UITableView *)tableView canMoveRowAtIndexPath:(NSIndexPath *)indexPath {
    // Return NO if you do not want the item to be re-orderable.
    return YES;
}
*/


#pragma mark - Table view delegate

// In a xib-based application, navigation from a table can be handled in -tableView:didSelectRowAtIndexPath:
- (void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath {
    CellTagType tag = [self whichCellTag:indexPath];
    
    switch (tag) {
        case CellTagMode:
            //[ass editMode];
            break;
        case CellTagServerAddress:
            [ass editServerAddress];
            break;
        case CellTagServerPort:
            [ass editServerPort];
            break;
        case CellTagResetToDefault:
            [ass resetToDefaultSetting];
            break;
        case CellTagStart: {
            [asc setSensingSetting:ass];
        }
            break;
        default:
            break;
    }
    
    // Navigation logic may go here, for example:
    // Create the next view controller.
    // <#DetailViewController#> *detailViewController = [[<#DetailViewController#> alloc] initWithNibName:<#@"Nib name"#> bundle:nil];
    
    // Pass the selected object to the new view controller.
    
    
    // Push the view controller.
    // TODO: follow this method
    // [self.navigationController pushViewController:detailViewController animated:YES];
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

- (void)updateAndRefreshDebugStatus:(NSString *)status {
    [debugStatus setString:status];
    UITableView *tv = (UITableView *)[self view];
    [tv reloadData];
}

- (void)modeChanged {
    [ass setMode: [modeSegmentControl titleForSegmentAtIndex:[modeSegmentControl selectedSegmentIndex]]];
}

- (void)micChanged {
    [ass setRecorderMic:[micSegmentControl titleForSegmentAtIndex:[micSegmentControl selectedSegmentIndex]]];
}

- (void)speakerChanged {
    [ass setPlaySpeaker:[speakerSegmentControl titleForSegmentAtIndex:[speakerSegmentControl selectedSegmentIndex]]];
}

// will be called after finish select in select views
- (void)finishEditSetting {
    //[inputCollection clean];
    UITableView *tv = (UITableView *)[self view];
    [tv reloadData];
}

//==================================================================================================
//	Acoustic sensing controller callbacks
//==================================================================================================
- (void)updateDebugStatus:(NSString *)status {
    NSLog(@"updateDebugStatus: %@", status);
    [self updateAndRefreshDebugStatus:status];
}
- (void)unexpectedEnd:(int)code withReason:(NSString *)reason {
    [self updateAndRefreshDebugStatus:reason];
}

- (void)readyToSense:(BOOL)isReadyToSense message:(NSString *)message {
    NSLog(@"readyToSense: %d, message = %@", isReadyToSense, message);
    if (isReadyToSense) {
        RemoteSensingViewController *vc = [[RemoteSensingViewController alloc] initWithAcousticSensingController:asc];
        [[self navigationController] pushViewController:vc animated:YES];
    } else {
        [self updateAndRefreshDebugStatus:message];
    }
}

- (void)sensingStarted {
    
}
- (void)sensingFinished {
    
}

@end
