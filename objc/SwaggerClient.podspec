#
# Be sure to run `pod lib lint SwaggerClient.podspec' to ensure this is a
# valid spec and remove all comments before submitting the spec.
#
# Any lines starting with a # are optional, but encouraged
#
# To learn more about a Podspec see http://guides.cocoapods.org/syntax/podspec.html
#

Pod::Spec.new do |s|
    s.name             = "SwaggerClient"
    s.version          = "1.0.0"

    s.summary          = "Route Optimization API"
    s.description      = <<-DESC
                         Our Route Optimization API solves the so called vehicle routing problem fast. It calculates an optimal tour for a set of vehicles, services and constraints
                         DESC

    s.platform     = :ios, '7.0'
    s.requires_arc = true

    s.framework    = 'SystemConfiguration'

    s.homepage     = "https://github.com/swagger-api/swagger-codegen"
    s.license      = "Proprietary"
    s.source       = { :git => "https://github.com/swagger-api/swagger-codegen.git", :tag => "#{s.version}" }
    s.author       = { "Swagger" => "apiteam@swagger.io" }

    s.source_files = 'SwaggerClient/**/*.{m,h}'
    s.public_header_files = 'SwaggerClient/**/*.h'


    s.dependency 'AFNetworking', '~> 3.1'
    s.dependency 'JSONModel', '~> 1.4'
    s.dependency 'ISO8601', '~> 0.5'
end

