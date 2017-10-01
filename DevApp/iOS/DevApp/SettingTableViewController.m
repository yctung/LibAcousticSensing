//
//  SettingTableViewController.m
//  DevApp
//
//  Created by Yu-Chih on 10/1/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "SettingTableViewController.h"
#import "AppConstant.h"
#import "InputViewControllerCollection.h"
#import "SelectNumberViewController.h"

@interface SettingTableViewController ()
    
@end

@implementation SettingTableViewController
//@synthesize tableView;

- (id)initWithNibName:(NSString *)nibNameOrNil bundle:(NSBundle *)nibBundleOrNil {
    if ((self = [super initWithNibName:nibNameOrNil bundle:nibBundleOrNil])) {
        // TODO: init preference
        [self setTitle:@"Setting"];
        
        ass = [[AcousticSensingSetting alloc] init];
        NSString *temp = [ass getServerAddress];
        
        serverAddressString = [[NSMutableString alloc] initWithString:temp];
        inputCollection = [[InputViewControllerCollection alloc] initWithControlString:@"NDW" andCaller:self];
        
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
    return 3;
}

- (NSString *)tableView: (UITableView *)tableView titleForHeaderInSection:(NSInteger) section {
    switch (section) {
        case 0:
            return @"Mode";
            break;
        case 1:
            return @"Audio";
            break;
        case 2:
            return @"Action";
            break;
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
    }
    //NSLog(@"[WARN]: undefined section number = %ld", (long)section);
    return 0;
}


- (UITableViewCell *)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath {
    static NSString *cellId = @"Cell";
    
    //UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:cellId forIndexPath:indexPath];
    // we should use the shorter version of this dequeue method to avoid the error of
    // "unable to dequeue a cell with identifier Cell - must register a nib or a class for the identifier"
    // ref: https://stackoverflow.com/questions/23526756/unable-to-dequeue-a-cell-with-identifier-cell-must-register-a-nib-or-a-class-f
    UITableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:cellId];
    
    // Configure the cell...
    if (cell == nil) {
        cell = [[[UITableViewCell alloc] initWithStyle:UITableViewCellStyleValue1 reuseIdentifier:cellId] autorelease];
        cell.selectionStyle = UITableViewCellSelectionStyleNone;
    }
    
    CellTagType tag = [self whichCellTag:indexPath];
    switch (tag) {
        case CellTagMode:
            cell.textLabel.text = @"Mode";
            
            break;
        case CellTagServerAddress:
            cell.textLabel.text = @"Server IP";
            cell.detailTextLabel.text = serverAddressString;
            break;
        case CellTagServerPort:
            cell.textLabel.text = @"Server Port";
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
        case CellTagServerAddress: {
            UIAlertController * alertController = [UIAlertController alertControllerWithTitle: @"Login"
                                                                                      message: @"Input username and password"
                                                                               preferredStyle:UIAlertControllerStyleAlert];
            [alertController addTextFieldWithConfigurationHandler:^(UITextField *textField) {
                textField.placeholder = @"name";
                textField.textColor = [UIColor blueColor];
                textField.clearButtonMode = UITextFieldViewModeWhileEditing;
                textField.borderStyle = UITextBorderStyleRoundedRect;
            }];
            [alertController addTextFieldWithConfigurationHandler:^(UITextField *textField) {
                textField.placeholder = @"password";
                textField.textColor = [UIColor blueColor];
                textField.clearButtonMode = UITextFieldViewModeWhileEditing;
                textField.borderStyle = UITextBorderStyleRoundedRect;
                textField.secureTextEntry = YES;
            }];
            [alertController addAction:[UIAlertAction actionWithTitle:@"OK" style:UIAlertActionStyleDefault handler:^(UIAlertAction *action) {
                NSArray * textfields = alertController.textFields;
                UITextField * namefield = textfields[0];
                UITextField * passwordfiled = textfields[1];
                NSLog(@"%@:%@",namefield.text,passwordfiled.text);
                NSUserDefaults *pref = [NSUserDefaults standardUserDefaults];
                [pref setObject:namefield.text forKey:LIBAS_SETTING_SERVER_ADDR_KEY];
                
            }]];
            [self presentViewController:alertController animated:YES completion:nil];
            
            
            break;
        }
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

// will be called after finish select in select views
- (void)inputFinishedThenReloadData{
    [inputCollection clean];
    //[myTableView reloadData];
    
}

@end
