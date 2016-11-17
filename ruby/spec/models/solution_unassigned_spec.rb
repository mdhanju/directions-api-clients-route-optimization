=begin
#Route Optimization API

#Our Route Optimization API solves the so called vehicle routing problem fast. It calculates an optimal tour for a set of vehicles, services and constraints

OpenAPI spec version: 1.0

Generated by: https://github.com/swagger-api/swagger-codegen.git

=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for GraphHopper::SolutionUnassigned
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'SolutionUnassigned' do
  before do
    # run before each test
    @instance = GraphHopper::SolutionUnassigned.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of SolutionUnassigned' do
    it 'should create an instact of SolutionUnassigned' do
      expect(@instance).to be_instance_of(GraphHopper::SolutionUnassigned)
    end
  end
  describe 'test attribute "services"' do
    it 'should work' do
       # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  describe 'test attribute "shipments"' do
    it 'should work' do
       # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end

