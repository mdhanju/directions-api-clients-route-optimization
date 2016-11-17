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
from swagger_client.models.cost_matrix import CostMatrix


class TestCostMatrix(unittest.TestCase):
    """ CostMatrix unit test stubs """

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testCostMatrix(self):
        """
        Test CostMatrix
        """
        model = swagger_client.models.cost_matrix.CostMatrix()


if __name__ == '__main__':
    unittest.main()
