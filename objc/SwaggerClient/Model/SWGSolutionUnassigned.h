#import <Foundation/Foundation.h>
#import "SWGObject.h"

/**
* Route Optimization API
* Our Route Optimization API solves the so called vehicle routing problem fast. It calculates an optimal tour for a set of vehicles, services and constraints
*
* OpenAPI spec version: 1.0
* 
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/




@protocol SWGSolutionUnassigned
@end

@interface SWGSolutionUnassigned : SWGObject

/* An array of ids of unassigned services [optional]
 */
@property(nonatomic) NSArray<NSString*>* services;
/* An array of ids of unassigned shipments [optional]
 */
@property(nonatomic) NSArray<NSString*>* shipments;

@end
