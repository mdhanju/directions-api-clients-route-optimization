/*
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


package com.graphhopper.routeopt.client.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;
import com.graphhopper.routeopt.client.model.Route;
import com.graphhopper.routeopt.client.model.SolutionUnassigned;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;

/**
 * Solution
 */
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-11-17T16:48:01.691+01:00")
public class Solution {
  @SerializedName("costs")
  private Integer costs = null;

  @SerializedName("distance")
  private Integer distance = null;

  @SerializedName("time")
  private Long time = null;

  @SerializedName("transport_time")
  private Long transportTime = null;

  @SerializedName("max_operation_time")
  private Long maxOperationTime = null;

  @SerializedName("waiting_time")
  private Long waitingTime = null;

  @SerializedName("no_vehicles")
  private Integer noVehicles = null;

  @SerializedName("no_unassigned")
  private Integer noUnassigned = null;

  @SerializedName("routes")
  private List<Route> routes = new ArrayList<Route>();

  @SerializedName("unassigned")
  private SolutionUnassigned unassigned = null;

  public Solution costs(Integer costs) {
    this.costs = costs;
    return this;
  }

   /**
   * overall costs of solution
   * @return costs
  **/
  @ApiModelProperty(example = "null", value = "overall costs of solution")
  public Integer getCosts() {
    return costs;
  }

  public void setCosts(Integer costs) {
    this.costs = costs;
  }

  public Solution distance(Integer distance) {
    this.distance = distance;
    return this;
  }

   /**
   * overall travel distance in meters
   * @return distance
  **/
  @ApiModelProperty(example = "null", value = "overall travel distance in meters")
  public Integer getDistance() {
    return distance;
  }

  public void setDistance(Integer distance) {
    this.distance = distance;
  }

  public Solution time(Long time) {
    this.time = time;
    return this;
  }

   /**
   * overall transport time in ms
   * @return time
  **/
  @ApiModelProperty(example = "null", value = "overall transport time in ms")
  public Long getTime() {
    return time;
  }

  public void setTime(Long time) {
    this.time = time;
  }

  public Solution transportTime(Long transportTime) {
    this.transportTime = transportTime;
    return this;
  }

   /**
   * overall transport time in ms
   * @return transportTime
  **/
  @ApiModelProperty(example = "null", value = "overall transport time in ms")
  public Long getTransportTime() {
    return transportTime;
  }

  public void setTransportTime(Long transportTime) {
    this.transportTime = transportTime;
  }

  public Solution maxOperationTime(Long maxOperationTime) {
    this.maxOperationTime = maxOperationTime;
    return this;
  }

   /**
   * operation time of the longest route in ms
   * @return maxOperationTime
  **/
  @ApiModelProperty(example = "null", value = "operation time of the longest route in ms")
  public Long getMaxOperationTime() {
    return maxOperationTime;
  }

  public void setMaxOperationTime(Long maxOperationTime) {
    this.maxOperationTime = maxOperationTime;
  }

  public Solution waitingTime(Long waitingTime) {
    this.waitingTime = waitingTime;
    return this;
  }

   /**
   * total waiting time in ms
   * @return waitingTime
  **/
  @ApiModelProperty(example = "null", value = "total waiting time in ms")
  public Long getWaitingTime() {
    return waitingTime;
  }

  public void setWaitingTime(Long waitingTime) {
    this.waitingTime = waitingTime;
  }

  public Solution noVehicles(Integer noVehicles) {
    this.noVehicles = noVehicles;
    return this;
  }

   /**
   * number of employed vehicles
   * @return noVehicles
  **/
  @ApiModelProperty(example = "null", value = "number of employed vehicles")
  public Integer getNoVehicles() {
    return noVehicles;
  }

  public void setNoVehicles(Integer noVehicles) {
    this.noVehicles = noVehicles;
  }

  public Solution noUnassigned(Integer noUnassigned) {
    this.noUnassigned = noUnassigned;
    return this;
  }

   /**
   * number of jobs that could not be assigned to final solution
   * @return noUnassigned
  **/
  @ApiModelProperty(example = "null", value = "number of jobs that could not be assigned to final solution")
  public Integer getNoUnassigned() {
    return noUnassigned;
  }

  public void setNoUnassigned(Integer noUnassigned) {
    this.noUnassigned = noUnassigned;
  }

  public Solution routes(List<Route> routes) {
    this.routes = routes;
    return this;
  }

  public Solution addRoutesItem(Route routesItem) {
    this.routes.add(routesItem);
    return this;
  }

   /**
   * An array of routes
   * @return routes
  **/
  @ApiModelProperty(example = "null", value = "An array of routes")
  public List<Route> getRoutes() {
    return routes;
  }

  public void setRoutes(List<Route> routes) {
    this.routes = routes;
  }

  public Solution unassigned(SolutionUnassigned unassigned) {
    this.unassigned = unassigned;
    return this;
  }

   /**
   * Get unassigned
   * @return unassigned
  **/
  @ApiModelProperty(example = "null", value = "")
  public SolutionUnassigned getUnassigned() {
    return unassigned;
  }

  public void setUnassigned(SolutionUnassigned unassigned) {
    this.unassigned = unassigned;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Solution solution = (Solution) o;
    return Objects.equals(this.costs, solution.costs) &&
        Objects.equals(this.distance, solution.distance) &&
        Objects.equals(this.time, solution.time) &&
        Objects.equals(this.transportTime, solution.transportTime) &&
        Objects.equals(this.maxOperationTime, solution.maxOperationTime) &&
        Objects.equals(this.waitingTime, solution.waitingTime) &&
        Objects.equals(this.noVehicles, solution.noVehicles) &&
        Objects.equals(this.noUnassigned, solution.noUnassigned) &&
        Objects.equals(this.routes, solution.routes) &&
        Objects.equals(this.unassigned, solution.unassigned);
  }

  @Override
  public int hashCode() {
    return Objects.hash(costs, distance, time, transportTime, maxOperationTime, waitingTime, noVehicles, noUnassigned, routes, unassigned);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Solution {\n");
    
    sb.append("    costs: ").append(toIndentedString(costs)).append("\n");
    sb.append("    distance: ").append(toIndentedString(distance)).append("\n");
    sb.append("    time: ").append(toIndentedString(time)).append("\n");
    sb.append("    transportTime: ").append(toIndentedString(transportTime)).append("\n");
    sb.append("    maxOperationTime: ").append(toIndentedString(maxOperationTime)).append("\n");
    sb.append("    waitingTime: ").append(toIndentedString(waitingTime)).append("\n");
    sb.append("    noVehicles: ").append(toIndentedString(noVehicles)).append("\n");
    sb.append("    noUnassigned: ").append(toIndentedString(noUnassigned)).append("\n");
    sb.append("    routes: ").append(toIndentedString(routes)).append("\n");
    sb.append("    unassigned: ").append(toIndentedString(unassigned)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}

