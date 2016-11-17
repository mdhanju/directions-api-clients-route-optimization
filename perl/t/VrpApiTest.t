=begin comment

Route Optimization API

Our Route Optimization API solves the so called vehicle routing problem fast. It calculates an optimal tour for a set of vehicles, services and constraints

OpenAPI spec version: 1.0

Generated by: https://github.com/swagger-api/swagger-codegen.git

=end comment

=cut

#
# NOTE: This class is auto generated by Swagger Codegen
# Please update the test cases below to test the API endpoints.
# Ref: https://github.com/swagger-api/swagger-codegen
#
use Test::More tests => 1; #TODO update number of test cases
use Test::Exception;

use lib 'lib';
use strict;
use warnings;

use_ok('WWW::SwaggerClient::VrpApi');

my $api = WWW::SwaggerClient::VrpApi->new();
isa_ok($api, 'WWW::SwaggerClient::VrpApi');

#
# post_vrp test
#
{
    my $key = undef; # replace NULL with a proper value
    my $body = undef; # replace NULL with a proper value
    my $result = $api->post_vrp(key => $key, body => $body);
}


1;
