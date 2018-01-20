# Command Pattern

Behavioral Design Pattern

Personal Notes
- Client and Invoker can be thought of as independent services as well
- Command pattern will make sense if Client doesn't expect a response from the command immediately. It is async and Client may come to know that command has executed successfully through some side-effect.
- In system where client and invoker can be essentially same; in those cases, command created by client can be directly executed instead of a hop through invoker.