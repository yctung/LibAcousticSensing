//
//  AppDelegate.m
//  DevApp
//
//  Created by Yu-Chih on 1/18/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "AppDelegate.h"
#import "SettingTableViewController.h"

@interface AppDelegate ()

@end

@implementation AppDelegate

@synthesize navController;

- (BOOL)application:(UIApplication *)application didFinishLaunchingWithOptions:(NSDictionary *)launchOptions {
    // Override point for customization after application launch.
    
    // Disable storyborad and use xib as layout xml
    // ref: http://stackoverflow.com/questions/36619756/xcode-7-3-cant-create-xib-with-for-uiview-uitableviewcelltogether
    CGRect screenBounds = [[UIScreen mainScreen] bounds];
    UIWindow *window = [[UIWindow alloc] initWithFrame:screenBounds];
    //ServerClientViewController *rootViewController = [[ServerClientViewController alloc] init];
    SettingTableViewController *rootViewController = [[SettingTableViewController alloc] initWithNibName:@"SettingTableViewController" bundle:nil];
    navController = [[UINavigationController alloc] initWithRootViewController:rootViewController];
    [window setRootViewController:navController];
    [window makeKeyAndVisible];
    return YES;
}

- (void)applicationWillResignActive:(UIApplication *)application {
    // Sent when the application is about to move from active to inactive state. This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) or when the user quits the application and it begins the transition to the background state.
    // Use this method to pause ongoing tasks, disable timers, and throttle down OpenGL ES frame rates. Games should use this method to pause the game.
}

- (void)applicationDidEnterBackground:(UIApplication *)application {
    // Use this method to release shared resources, save user data, invalidate timers, and store enough application state information to restore your application to its current state in case it is terminated later.
    // If your application supports background execution, this method is called instead of applicationWillTerminate: when the user quits.
}

- (void)applicationWillEnterForeground:(UIApplication *)application {
    // Called as part of the transition from the background to the inactive state; here you can undo many of the changes made on entering the background.
}

- (void)applicationDidBecomeActive:(UIApplication *)application {
    // Restart any tasks that were paused (or not yet started) while the application was inactive. If the application was previously in the background, optionally refresh the user interface.
}

- (void)applicationWillTerminate:(UIApplication *)application {
    // Called when the application is about to terminate. Save data if appropriate. See also applicationDidEnterBackground:.
}

@end
