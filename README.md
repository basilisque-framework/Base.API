<!--
   Copyright 2026 Alexander Stärk

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
-->
# Basilisque - Base API

## Overview
This project provides common functionality for ASP.Net API projects.

[![NuGet Basilisque.Base.API](https://img.shields.io/badge/NuGet_Basilisque.Base.API-latest-%23004880.svg?logo=nuget)](https://www.nuget.org/packages/Basilisque.Base.API)  
[![License](https://img.shields.io/badge/License-Apache%20License%202.0-%23D22128.svg?logo=apache&logoColor=%23D22128)](LICENSE.txt)  
[![SonarCloud](https://img.shields.io/badge/SonarCloud-main-%23F3702A.svg?logo=sonarcloud&logoColor=%23F3702A)](https://sonarcloud.io/project/overview?id=basilisque-framework_Base.API)  

## Description
This project contains common functionality for ASP.Net API projects.  
It mainly contains interfaces for registering Minimal API endpoints accross the whole project without linking them all at a single place.

## Getting Started
Install the NuGet package [Basilisque.Base.API](https://www.nuget.org/packages/Basilisque.Base.API).  

Create a new registration class for your API implementing `IEndpoint`.

## License
The Basilisque framework (including this repository) is licensed under the [Apache License, Version 2.0](LICENSE.txt).