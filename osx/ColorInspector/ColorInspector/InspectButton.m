//
//  InspectButton.m
//  ColorInspector
//
//  Created by Alan Rahlf on 8/16/15.
//  Copyright (c) 2015 Alan Rahlf. All rights reserved.
//

#import "InspectButton.h"

@implementation InspectButton

- (void)mouseDown:(NSEvent *)theEvent {
    // Specifically not calling super here because it prevents mouseUp from ever firing.
    
    self.highlighted = YES;
    
    [self.delegate onMouseDown:self];
}

- (void)mouseUp:(NSEvent *)theEvent {
    self.highlighted = NO;
}

@end