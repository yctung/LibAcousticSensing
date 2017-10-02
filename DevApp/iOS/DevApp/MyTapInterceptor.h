//
//  MyTapInterceptor.h
//  KingFongVer2
//
//  Created by eddyxd don on 3/14/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import <UIKit/UIKit.h>

typedef void (^TouchesEventBlock)(NSSet * touches, UIEvent * event);


@interface MyTapInterceptor : UIGestureRecognizer {
	TouchesEventBlock touchesBeganCallback;
	TouchesEventBlock touchesEndedCallback;
}

@property(copy) TouchesEventBlock touchesBeganCallback;
@property(copy) TouchesEventBlock touchesEndedCallback;

@end
