#!/bin/sh -e


PUBLISHED_PACKAGE__DIR="./published"
PACKAGES_DIR="packages"

usage() 
{
  echo "Usage:"
  echo "./package.sh Release|Debug"
  echo
}

description() 
{
  echo ""
  echo "##############################################"
  echo "$1"
  echo "##############################################"
  echo ""
}

if [ -z "$1" ]
then
  usage
  exit 1
fi

if [ "$1" != "Release" ] && [ "$1" != "Debug" ]
then
  usage
  exit 1
fi



if [ -d $PUBLISHED_PACKAGE__DIR ]
then
  rm -rvf $PUBLISHED_PACKAGE__DIR
fi

echo "Creating 'published' directory..." 
mkdir $PUBLISHED_PACKAGE__DIR

description "Building project..."
dotnet clean -c $1
dotnet build -c $1

description "Creating nuget packages..."
dotnet pack -o $PUBLISHED_PACKAGE__DIR

# todo: add readme file to nuget package

count=$(ls $PUBLISHED_PACKAGE__DIR/*.nupkg | wc -l)

if [ $count == 0 ] 
then
   exit 1
fi


if [ ! -d ../$PACKAGES_DIR ]
then
  mkdir ../$PACKAGES_DIR
fi

packagePath=$(ls $PUBLISHED_PACKAGE__DIR/*.nupkg)
IFS='/' read -ra arr <<< "$packagePath"
packageName="${arr[${#arr[@]}-1]}"

description "copy $PUBLISHED_PACKAGE__DIR/$packageName to ./$PACKAGES_DIR/$packageName"

cp $PUBLISHED_PACKAGE__DIR/$packageName ../$PACKAGES_DIR/.




