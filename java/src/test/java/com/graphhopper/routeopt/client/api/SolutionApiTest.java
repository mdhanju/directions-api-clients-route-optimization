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


package com.graphhopper.routeopt.client.api;

import com.graphhopper.routeopt.client.ApiException;
import com.graphhopper.routeopt.client.model.Response;
import org.junit.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for SolutionApi
 */
public class SolutionApiTest {

    private final SolutionApi api = new SolutionApi();

    
    /**
     * Return the solution associated to the jobId
     *
     * This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent. 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void getSolutionTest() throws ApiException {
        String key = null;
        String jobId = null;
        // Response response = api.getSolution(key, jobId);

        // TODO: test validations
    }
    
}
