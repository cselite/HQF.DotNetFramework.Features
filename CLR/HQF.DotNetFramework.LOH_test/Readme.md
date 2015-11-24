
##Large Object Heap Compaction: Should You Use it?
https://www.simple-talk.com/dotnet/.net-framework/large-object-heap-compaction-should-you-use-it/ 


###So what can you do to avoid LOH fragmentation?

Generally, solving LOH fragmentation problems requires following one of the three strategies:

- Figure out which large objects are responsible for fragmentation, and then break them down into smaller parts which are assimilated into a functionally equivalent wrapper class.  
- Re-architect parts of the application to reduce the churn of large objects  
- Periodically restart the application (this is essentially what recycling app pools for ASP.NET applications seeks to achieve)  

Each of these solutions are either difficult, inelegant, laborious, or a combination thereof. However, in .NET 4.5.1 the .NET team at Microsoft has provided another possibility by adding the ability to easily do a one-off garbage collection, followed by a LOH compaction, with the following code:  
```c#
GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce; GC.Collect(); // This can be omitted

If GC.Collect() is omitted then the LOH compaction will happen when the next LOH garbage collection occurs naturally. After this modified garbage collection has finished the application will continue running as before (i.e. with no LOH compactions).
```

Microsoft deliberately chose not to compact the LOH by default when it is garbage collected (unlike the small object heaps) because they believe that the performance impact of regularly performing a LOH compaction outweighs the benefits of doing so. In an MSDN blog announcing the release of .NET 4.5.1, the Microsoft .NET team give the following warning concerning using LOH compaction:  

“`LOH compaction` can be an expensive operation and should only be used after significant performance analysis, both to determine that LOH fragmentation is a problem, but also to decide when to request compaction.”  
Here I will seek to explain in more detail what actually happens during a LOH compaction, and clarify when it is appropriate to use it.  

###So when should you use compaction?
I would recommend using the `LOH compaction` only if the following criteria are satisfied:

 - You are already targeting .NET 4.5.1 or can upgrade to it.   
 - Pauses of the length estimated in the previous section don’t seriously affect the usability of your application.  
 - It is not possible to pursue strategies of breaking large objects down into smaller chunks, or reducing large object churn.  

I think this is a very useful few feature in the .NET framework, and it suggests that more developers are realising that they need to at least be aware of what’s happening beneath all the abstractions if they want to build really great software. However, I also think that it should be a strategy of last resort.