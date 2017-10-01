//
//  SelectOverlay.h
//  KingFongVer2
//
//  Created by eddyxd don on 4/8/11.
//  Copyright 2011 __MyCompanyName__. All rights reserved.
//

#import <UIKit/UIKit.h>


@interface SelectOverlay : UIButton {
	id refCaller;
}
@property (nonatomic, assign) id refCaller;
- (void) show;
- (void) disapper;
@end
