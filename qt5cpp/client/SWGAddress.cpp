/**
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


#include "SWGAddress.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGAddress::SWGAddress(QString* json) {
    init();
    this->fromJson(*json);
}

SWGAddress::SWGAddress() {
    init();
}

SWGAddress::~SWGAddress() {
    this->cleanup();
}

void
SWGAddress::init() {
    location_id = new QString("");
    lon = 0.0;
    lat = 0.0;
}

void
SWGAddress::cleanup() {
    
    if(location_id != nullptr) {
        delete location_id;
    }


}

SWGAddress*
SWGAddress::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGAddress::fromJsonObject(QJsonObject &pJson) {
    ::Swagger::setValue(&location_id, pJson["location_id"], "QString", "QString");
    ::Swagger::setValue(&lon, pJson["lon"], "double", "");
    ::Swagger::setValue(&lat, pJson["lat"], "double", "");
}

QString
SWGAddress::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGAddress::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    toJsonValue(QString("location_id"), location_id, obj, QString("QString"));

    obj->insert("lon", QJsonValue(lon));

    obj->insert("lat", QJsonValue(lat));

    return obj;
}

QString*
SWGAddress::getLocationId() {
    return location_id;
}
void
SWGAddress::setLocationId(QString* location_id) {
    this->location_id = location_id;
}

double
SWGAddress::getLon() {
    return lon;
}
void
SWGAddress::setLon(double lon) {
    this->lon = lon;
}

double
SWGAddress::getLat() {
    return lat;
}
void
SWGAddress::setLat(double lat) {
    this->lat = lat;
}



} /* namespace Swagger */

