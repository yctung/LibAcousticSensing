//
//  ViewController.m
//  DevApp
//
//  Created by Yu-Chih on 1/18/17.
//  Copyright © 2017 Yu-Chih. All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view, typically from a nib.
    int check=[FrameworkCheck showMe1];
    NSLog(@"check=%d",check);
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}

@end
