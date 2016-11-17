# coding: utf-8

"""
    Route Optimization API

    Our Route Optimization API solves the so called vehicle routing problem fast. It calculates an optimal tour for a set of vehicles, services and constraints

    OpenAPI spec version: 1.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from __future__ import absolute_import

import os
import sys
import unittest

import swagger_client
from swagger_client.rest import ApiException
from swagger_client.apis.solution_api import SolutionApi


class TestSolutionApi(unittest.TestCase):
    """ SolutionApi unit test stubs """

    def setUp(self):
        self.api = swagger_client.apis.solution_api.SolutionApi()

    def tearDown(self):
        pass

    def test_get_solution(self):
        """
        Test case for get_solution

        Return the solution associated to the jobId
        """
        pass


if __name__ == '__main__':
    unittest.main()
