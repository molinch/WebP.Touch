//
//  xcode_tvos.h
//  xcode.tvos
//
//  Created by Tuyen Vu on 10/10/19.
//  Copyright © 2019 NAXAM. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@interface WebPDecoder : NSObject

-(UIImage*)imageWithWebP:(NSString*)filePath error:(NSError **)error;

-(UIImage*)imageWithWebPData:(NSData*)imgData error:(NSError **)error;

-(int)getVersion;

@end
