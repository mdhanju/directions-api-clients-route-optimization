# coding: utf-8

"""
    Route Optimization API

    Our Route Optimization API solves the so called vehicle routing problem fast. It calculates an optimal tour for a set of vehicles, services and constraints

    OpenAPI spec version: 1.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


from pprint import pformat
from six import iteritems
import re


class SolutionUnassigned(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, services=None, shipments=None):
        """
        SolutionUnassigned - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'services': 'list[str]',
            'shipments': 'list[str]'
        }

        self.attribute_map = {
            'services': 'services',
            'shipments': 'shipments'
        }

        self._services = services
        self._shipments = shipments


    @property
    def services(self):
        """
        Gets the services of this SolutionUnassigned.
        An array of ids of unassigned services

        :return: The services of this SolutionUnassigned.
        :rtype: list[str]
        """
        return self._services

    @services.setter
    def services(self, services):
        """
        Sets the services of this SolutionUnassigned.
        An array of ids of unassigned services

        :param services: The services of this SolutionUnassigned.
        :type: list[str]
        """

        self._services = services

    @property
    def shipments(self):
        """
        Gets the shipments of this SolutionUnassigned.
        An array of ids of unassigned shipments

        :return: The shipments of this SolutionUnassigned.
        :rtype: list[str]
        """
        return self._shipments

    @shipments.setter
    def shipments(self, shipments):
        """
        Sets the shipments of this SolutionUnassigned.
        An array of ids of unassigned shipments

        :param shipments: The shipments of this SolutionUnassigned.
        :type: list[str]
        """

        self._shipments = shipments

    def to_dict(self):
        """
        Returns the model properties as a dict
        """
        result = {}

        for attr, _ in iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """
        Returns the string representation of the model
        """
        return pformat(self.to_dict())

    def __repr__(self):
        """
        For `print` and `pprint`
        """
        return self.to_str()

    def __eq__(self, other):
        """
        Returns true if both objects are equal
        """
        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """
        Returns true if both objects are not equal
        """
        return not self == other
