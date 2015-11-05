
  
**Introduction**  
This article discusses the features introduced in Microsoft .Net Framework 2.0, 3.0, 3.5, 4.0 and the newly introduced 4.5 framework.   
  
**.Net Framework 2.0 Features  
**  
**ADO.NET**  
New features in ADO.NET include support for user-defined types (UDT), asynchronous database operations, XML data types, large value types, snapshot isolation, and new attributes that allow applications to support multiple active result sets (MARS) with SQL Server 2005.  
  
**ASP.NET**  
The Microsoft .NET Framework 2.0 includes significant enhancements to all areas of ASP.NET. For Web page development, new controls make it easier to add commonly used functionality to dynamic Web pages. New data controls make it possible to display and edit data on an ASP.NET Web page without writing code. An improved code-behind model makes developing ASP.NET pages easier and more robust. Caching features provide several new ways to cache pages, including the ability to build cache dependency on tables in a SQL Server database.  
  
ASP.NET accommodates a wide variety of browsers and devices. By default, controls render output that is compatible with XHTML 1.1 standards. You can use device filtering to specify different property values on the same control for different browsers.  
  
**.NET Remoting **  
  
.NET Framework Remoting now supports IPv6 addresses and the exchange of generic types. The classes in the System.Runtime.Remoting.Channels.Tcp namespace support authentication and encryption using the Security Support Provider Interface (SSPI). Classes in the new System.Runtime.Remoting.Channels.Ipc namespace allow applications on the same computer to communicate quickly without using the network. Finally, you can now configure the connection cache time-out and the number of method retries, which can improve the performance of network load-balanced remote clusters.  
  
**XML**  
The new System.Xml.XmlReaderSettings class allows specification of the type of verifications to be done when using a subclass of XmlReader to read XML data.  
  
It is now possible to partially validate a DOM tree loaded within an instance of XmlDocument.  
  
It is now possible to modify a DOM tree stored in an XmlDocument instance through the XPathNavigator cursor API.  
  
**.Net Framework 3.0/3.5 Features**  
**Windows Presentation Foundation (WPF)**  
  
Windows Presentation Foundation (WPF) is a next-generation presentation system for building Windows client applications. The core of WPF is a resolution-independent and vector-based rendering engine that is built to take advantage of modern graphics hardware.  
  
WPF extends the core with a comprehensive set of application-development features that include Extensible Application Markup Language (XAML), controls, data binding, layout, 2-D and 3-Dgraphics, animation, styles, templates, documents, media, text, and typography. WPF is included in the Microsoft .NET Framework, so you can build applications that incorporate other elements of the .NET Framework class library.  
  
To support some of the more powerful WPF capabilities and to simplify the programming experience, WPF includes additional programming constructs that enhance properties and events: dependency properties and routed events.  
  
**Windows Communication Foundation (WCF)**  
  
Windows Communication Foundation (WCF) is Microsoft's unified programming model for building service-oriented applications. WCF allows you to build many kinds of distributed applications including "traditional" Web Services so that your services support SOAP and will therefore be compatible with older .NET (and other) technologies. WCF is not just about pure SOAP over the wire - you can work with an Info set, and create a binary representation of your SOAP message that can then be sent along with your choice of protocol. This is for those who are particularly concerned about performance and have traditionally turned to .NET remoting.  
  
**Windows Workflow Foundation (WWF)**  
  
Windows Workflow Foundation, a core component of .NET Framework 3.0, provides a programming model, run-time engine, and tools for building workflow applications.  
  
A workflow is created and maintained by the workflow run-time engine. There can be several workflow engines within an application domain, and each workflow engine can support multiple workflows running concurrently. The run-time enables idle workflows to be unloaded from memory, persisted to a store, and reloaded whenever input is received.  
  
Workflows can be authored in code, XAML markup, or a combination of both, known as code-separation, which is similar to the ASP.NET mode.  
  
**Windows CardSpace (WCS)**  
  
Windows CardSpace (InfoCard) is a Digital Identity to online services. Digital Identity is how a user will be electronically represented. Such as for a debit/credit card, each card has a digital identity and password. If any user uses the site on internet then he enters their username and password, for identity, but this is not secure. WCS reduces these types of problems.   
  
WCS (originally called Info Card) helps people keep track of their digital identities as distinct information cards. If a Web site accepts WCS logins, users attempting to log in to that site will see a WCS selection. By choosing a card, users also choose a digital identity that will be used to access this site. CardSpace and the new supporting technologies will change how you authenticate into an application, whether it sits on the Web, your phone, or your desktop.  
  
**Core New Features and Improvements**  
  
Some core new features and improvements are implemented in .Net 3.0/3.5; they are:  

1. Auto Implemented Property
2. Implicit Typed local variable
3. Implicitly Typed Arrays
4. Anonymous Types
5. Extension Methods (3.5 new feature)
6. Object and Collection Initializers
7. Lambda Expressions  

**.Net Framework 4.0 Features**  
**Application Compatibility and Deployment**  
  
The .NET Framework 4 is highly compatible with applications that are built with earlier .NET Framework versions, except for some changes that were made to improve security, standards compliance, correctness, reliability, and performance.  
  
The .NET Framework 4 does not automatically use its version of the common language runtime to run applications that are built with earlier versions of the .NET Framework. To run older applications with .NET Framework 4, you must compile your application with the target .NET Framework version specified in the properties for your project in Visual Studio, or you can specify the supported runtime with the &lt;supportedRuntime&gt; Element in an application configuration file.  
  
**Core New Features and Improvements**  
  
Some new features are introduced in .Net framework 4.0.

The following sections describe new features and improvements provided by the common language runtime and the base class libraries.

1. BigInteger and Complex Numbers
2. Tuples
3. Covariance and Contravariance
4. Dynamic Language Runtime

**Managed Extensibility Framework**  
  
The Managed Extensibility Framework (MEF) is a new library in the .NET Framework 4 that helps you build extensible and composable applications. MEF enables you to specify points where an application can be extended, to expose services to offer to other extensible applications and to create parts for consumption by extensible applications.  
  
It also enables easy discoverability of available parts based on metadata, without the need to load the assemblies for the parts.  
  
**Parallel Computing**  
  
The .NET Framework 4 introduces a new programming model for writing multithreaded and asynchronous code that greatly simplifies the work of application and library developers. The new model enables developers to write efficient, fine-grained, and scalable parallel code in a natural idiom without having to work directly with threads or the thread pool. The new System.Threading.Tasks namespace and other related types support this new model.  
  
**Web**  
  
ASP.NET version 4 introduces new features in the following areas:

- Core services, including a new API that lets you extend caching, support for compression for session-state data, and a new application preload manager (autostart feature).
- Web Forms, including more integrated support for ASP.NET routing, enhanced support for Web standards, updated browser support, new features for data controls, and new features for view state management.
- Web Forms controls, including a new Chart control.
- MVC, including new helper methods for views, support for partitioned MVC applications, and asynchronous controllers.
- Dynamic Data, including support for existing Web applications, support for many-to-many relationships and inheritance, new field templates and attributes, and enhanced data filtering.
- Microsoft Ajax, including additional support for client-based Ajax applications in the Microsoft Ajax Library.
- Visual Web Developer, including improved IntelliSense for JScript, new auto-complete snippets for HTML and ASP.NET markup, and enhanced CSS compatibility.
- Deployment, including new tools for automating typical deployment tasks.
- Multi-targeting, including better filtering for features that are not available in the target version of the .NET Framework

**Windows Presentation Foundation (WPF) Features in 4.0 **  
Windows Presentation Foundation (WPF) version 4 contains changes and improvements in the following areas:

- New controls, including Calendar, Data Grid, and Date Picker.
- VisualStateManager supports changing states of controls.
- Touch and Manipulation enables you to create applications that receive input from multiple touches simultaneously on Windows 7.
- Graphics and animation supports layout rounding, Pixel Shader version 3.0, cached composition, and easing functions.
- Text has improved text rendering and supports customizing the caret color and selection color in text boxes.
- Binding is supported on the Command property of an InputBinding, dynamic objects, and the Text property.
- XAML browser applications (XBAPs) support communication with the Web page and support full-trust deployment.
- New types in the System.Windows.Shell namespace enable you to communicate with the Windows 7 taskbar and pass data to the Windows shell.
- The WPF and Silverlight Designer in Visual Studio 2010 has various designer improvements to help create WPF or Silverlight applications.

**Windows Communication Foundation Features in 4.0**  
  
Windows Communication Foundation (WCF) provides the following improvements:

- Configuration-based activation: Removes the requirement for having an .svc file.
- System.Web.Routing integration: Gives you more control over your service's URL by allowing the use of extensionless URLs.
- Multiple IIS site bindings support: Allows you to have multiple base addresses with the same protocol on the same Web site.
- Routing Service: Allows you to route messages based on content.
- Support for WS-Discovery: Allows you to create and search for discoverable services.
- Standard endpoints: Predefined endpoints that allow you to specify only certain properties.
- Workflow services: Integrates WCF and WF by providing activities to send and receive messages, the ability to correlate messages based on content, and a workflow service host.

**Windows Workflow Foundation Features in 4.0**  
  
Windows Workflow Foundation (WF) provides improvements in the following areas:

- Improved workflow activity model: The Activity class provides the base abstraction of workflow behavior.
- Rich composite activity options: Workflows benefit from new flow-control activities that model traditional flow-control structures, such as Flowchart, TryCatch, and Switch&lt;T&gt;.
- Expanded built-in activity library: New features of the activity library include new flow-control activities, activities for manipulating member data, and activities for controlling transactions.

**.Net Framework 4.5 Features**  
  
**.NET for Windows Store Apps**  
  
Windows Store apps are designed for specific form factors and leverage the power of the Windows operating system. A subset of the .NET Framework 4.5 is available for building Windows Store apps for Windows by using C# or Visual Basic.  
  
**Portable Class Libraries **  
  
The Portable Class Library project in Visual Studio 2012 enables you to write and build managed assemblies that work on multiple .NET Framework platforms. Using a Portable Class Library project, you choose the platforms (such as Windows Phone and .NET for Windows Store apps) to target.  
  
**ASP.NET 4.5**   
  
ASP.NET 4.5 includes the following new features:

- Support for new HTML5 form types.
- Support for model binders in Web Forms. These let you bind data controls directly to data-access methods, and automatically convert user input to and from .NET Framework data types.
- Support for unobtrusive JavaScript in client-side validation scripts.
- Improved handling of client script through bundling and minification for improved page performance.
- Integrated encoding routines from the AntiXSS library (previously an external library) to protect from cross-site scripting attacks.
- Support for WebSockets protocol.

**Windows Presentation Foundation (WPF) Features in 4.5  **In the .NET Framework 4.5, Windows Presentation Foundation (WPF) contains changes and improvements in the following areas:

- The new Ribbon control, which enables you to implement a ribbon user interface that hosts a Quick Access Toolbar, Application Menu, and tabs.
- The new INotifyDataErrorInfo interface, which supports synchronous and asynchronous data validation.
- New features for the VirtualizingPanel and Dispatcher classes.
- Improved performance when displaying large sets of grouped data, and by accessing collections on non-UI threads.
- Data binding to static properties, data binding to custom types that implement the ICustomTypeProvider interface, and retrieval of data binding information from a binding expression.
- Repositioning of data as the values change (live shaping).
- Ability to check whether the data context for an item container is disconnected.
- Ability to set the amount of time that should elapse between property changes and data source updates.
- Improved support for implementing weak event patterns. Also, events can now accept markup extensions.

**Windows Communication Foundation (WCF) Features in 4.5**  
  
In the .NET Framework 4.5, the following features have been added to make it simpler to write and maintain Windows Communication Foundation (WCF) applications:

- Simplification of generated configuration files.
- Support for contract-first development.
- Ability to configure ASP.NET compatibility mode more easily.
- Changes in default transport property values to reduce the likelihood that you will have to set them.
- Updates to the XmlDictionaryReaderQuotas class to reduce the likelihood that you will have to manually configure quotas for XML dictionary readers.
- Validation of WCF configuration files by Visual Studio as part of the build process, so you can detect configuration errors before you run your application.
- New asynchronous streaming support.
- New HTTPS protocol mapping to make it easier to expose an endpoint over HTTPS with Internet Information Services (IIS).
- Ability to generate metadata in a single WSDL document by appending ?singleWSDL to the service URL.
- Websockets support to enable true bidirectional communication over ports 80 and 443 with performance characteristics similar to the TCP transport.
- Support for configuring services in code.
- XML Editor tooltips.

**Windows Workflow Foundation (WF) Features in 4.5**  
  
Several new features have been added to Windows Workflow Foundation (WF) in the .NET Framework 4.5. These new features include:

- State machine workflows, which were first introduced as part of the .NET Framework 4.0.1 (.NET Framework 4 Platform Update 1). This update included several new classes and activities that enabled developers to create state machine workflows. These classes and activities were updated for the .NET Framework 4.5 to include:
- The ability to set breakpoints on states.
- The ability to copy and paste transitions in the workflow designer.
- Designer support for shared trigger transition creation.

**References**

- [http://msdn.microsoft.com/en-us/library/t357fb32.aspx](http://msdn.microsoft.com/en-us/library/t357fb32.aspx)
- [http://msdn.microsoft.com/en-us/library/aa479861.aspx](http://msdn.microsoft.com/en-us/library/aa479861.aspx)
- [http://msdn.microsoft.com/en-us/library/ms171868.aspx](http://msdn.microsoft.com/en-us/library/ms171868.aspx)
