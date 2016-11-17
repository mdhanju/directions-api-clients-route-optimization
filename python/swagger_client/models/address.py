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


class Address(object):
    """
    NOTE: This class is auto generated by the swagger code generator program.
    Do not edit the class manually.
    """
    def __init__(self, location_id=None, lon=None, lat=None):
        """
        Address - a model defined in Swagger

        :param dict swaggerTypes: The key is attribute name
                                  and the value is attribute type.
        :param dict attributeMap: The key is attribute name
                                  and the value is json key in definition.
        """
        self.swagger_types = {
            'location_id': 'str',
            'lon': 'float',
            'lat': 'float'
        }

        self.attribute_map = {
            'location_id': 'location_id',
            'lon': 'lon',
            'lat': 'lat'
        }

        self._location_id = location_id
        self._lon = lon
        self._lat = lat


    @property
    def location_id(self):
        """
        Gets the location_id of this Address.
        Unique identifier of location

        :return: The location_id of this Address.
        :rtype: str
        """
        return self._location_id

    @location_id.setter
    def location_id(self, location_id):
        """
        Sets the location_id of this Address.
        Unique identifier of location

        :param location_id: The location_id of this Address.
        :type: str
        """

        self._location_id = location_id

    @property
    def lon(self):
        """
        Gets the lon of this Address.
        longitude

        :return: The lon of this Address.
        :rtype: float
        """
        return self._lon

    @lon.setter
    def lon(self, lon):
        """
        Sets the lon of this Address.
        longitude

        :param lon: The lon of this Address.
        :type: float
        """

        self._lon = lon

    @property
    def lat(self):
        """
        Gets the lat of this Address.
        latitude

        :return: The lat of this Address.
        :rtype: float
        """
        return self._lat

    @lat.setter
    def lat(self, lat):
        """
        Sets the lat of this Address.
        latitude

        :param lat: The lat of this Address.
        :type: float
        """

        self._lat = lat

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
