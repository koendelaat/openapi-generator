/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.3.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * Foo.h
 *
 * 
 */

#ifndef Foo_H_
#define Foo_H_



#include <string>
#include <memory>
#include <vector>
#include <boost/property_tree/ptree.hpp>
#include "helpers.h"

namespace org {
namespace openapitools {
namespace server {
namespace model {

/// <summary>
/// 
/// </summary>
class  Foo 
{
public:
    Foo() = default;
    explicit Foo(boost::property_tree::ptree const& pt);
    virtual ~Foo() = default;

    Foo(const Foo& other) = default; // copy constructor
    Foo(Foo&& other) noexcept = default; // move constructor

    Foo& operator=(const Foo& other) = default; // copy assignment
    Foo& operator=(Foo&& other) noexcept = default; // move assignment

    std::string toJsonString(bool prettyJson = false) const;
    void fromJsonString(std::string const& jsonString);
    boost::property_tree::ptree toPropertyTree() const;
    void fromPropertyTree(boost::property_tree::ptree const& pt);


    /////////////////////////////////////////////
    /// Foo members

    /// <summary>
    /// 
    /// </summary>
    std::string getBar() const;
    void setBar(std::string value);

protected:
    std::string m_Bar = "bar";
};

std::vector<Foo> createFooVectorFromJsonString(const std::string& json);

template<>
inline boost::property_tree::ptree toPt<Foo>(const Foo& val) {
    return val.toPropertyTree();
}

template<>
inline Foo fromPt<Foo>(const boost::property_tree::ptree& pt) {
    Foo ret;
    ret.fromPropertyTree(pt);
    return ret;
}

}
}
}
}

#endif /* Foo_H_ */
