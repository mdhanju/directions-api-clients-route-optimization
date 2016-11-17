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

import (
	"net/url"
	"strings"
	"encoding/json"
	"fmt"
)

type SolutionApi struct {
	Configuration *Configuration
}

func NewSolutionApi() *SolutionApi {
	configuration := NewConfiguration()
	return &SolutionApi{
		Configuration: configuration,
	}
}

func NewSolutionApiWithBasePath(basePath string) *SolutionApi {
	configuration := NewConfiguration()
	configuration.BasePath = basePath

	return &SolutionApi{
		Configuration: configuration,
	}
}

/**
 * Return the solution associated to the jobId
 * This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent. 
 *
 * @param key your API key
 * @param jobId Request solution with jobId
 * @return *Response
 */
func (a SolutionApi) GetSolution(key string, jobId string) (*Response, *APIResponse, error) {

	var localVarHttpMethod = strings.ToUpper("Get")
	// create path and map variables
	localVarPath := a.Configuration.BasePath + "/solution/{jobId}"
	localVarPath = strings.Replace(localVarPath, "{"+"jobId"+"}", fmt.Sprintf("%v", jobId), -1)

	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := url.Values{}
	localVarFormParams := make(map[string]string)
	var localVarPostBody interface{}
	var localVarFileName string
	var localVarFileBytes []byte
	// authentication '(api_key)' required
	// set key with prefix in query string
	localVarQueryParams["key"] =  a.Configuration.GetAPIKeyWithPrefix("key")
	// add default headers if any
	for key := range a.Configuration.DefaultHeader {
		localVarHeaderParams[key] = a.Configuration.DefaultHeader[key]
	}
		localVarQueryParams.Add("key", a.Configuration.APIClient.ParameterToString(key, ""))

	// to determine the Content-Type header
	localVarHttpContentTypes := []string{ "application/json",  }

	// set Content-Type header
	localVarHttpContentType := a.Configuration.APIClient.SelectHeaderContentType(localVarHttpContentTypes)
	if localVarHttpContentType != "" {
		localVarHeaderParams["Content-Type"] = localVarHttpContentType
	}
	// to determine the Accept header
	localVarHttpHeaderAccepts := []string{
		"application/json",
		}

	// set Accept header
	localVarHttpHeaderAccept := a.Configuration.APIClient.SelectHeaderAccept(localVarHttpHeaderAccepts)
	if localVarHttpHeaderAccept != "" {
		localVarHeaderParams["Accept"] = localVarHttpHeaderAccept
	}
	var successPayload = new(Response)
	localVarHttpResponse, err := a.Configuration.APIClient.CallAPI(localVarPath, localVarHttpMethod, localVarPostBody, localVarHeaderParams, localVarQueryParams, localVarFormParams, localVarFileName, localVarFileBytes)

	var localVarURL, _ = url.Parse(localVarPath)
	localVarURL.RawQuery = localVarQueryParams.Encode()
	var localVarAPIResponse = &APIResponse{Operation: "GetSolution", Method: localVarHttpMethod, RequestURL: localVarURL.String()}
	if localVarHttpResponse != nil {
		localVarAPIResponse.Response = localVarHttpResponse.RawResponse
		localVarAPIResponse.Payload = localVarHttpResponse.Body()
	}

	if err != nil {
		return successPayload, localVarAPIResponse, err
	}
	err = json.Unmarshal(localVarHttpResponse.Body(), &successPayload)
	return successPayload, localVarAPIResponse, err
}

