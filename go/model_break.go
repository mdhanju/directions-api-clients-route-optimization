/* 
 * Route Optimization API
 *
 * Our Route Optimization API solves the so called vehicle routing problem fast. It calculates an optimal tour for a set of vehicles, services and constraints
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

package graphhopper

type ModelBreak struct {

	// earliest start of break
	Earliest int64 `json:"earliest,omitempty"`

	// latest start of break
	Latest int64 `json:"latest,omitempty"`

	// duration of break
	Duration int64 `json:"duration,omitempty"`

	// max driving time without break
	MaxDrivingTime int64 `json:"max_driving_time,omitempty"`

	// initial driving time, i.e. the time your driver has already spent for driving
	InitialDrivingTime int64 `json:"initial_driving_time,omitempty"`

	// array of splits
	PossibleSplit []int64 `json:"possible_split,omitempty"`
}
