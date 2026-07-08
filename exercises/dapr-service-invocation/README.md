# Exercise: Dapr Service Invocation

Call another participant's pod by name — no URLs, no namespace knowledge needed.

## What is happening

Each pod has a **Dapr sidecar** injected automatically. To call another participant's app,
you talk to your own sidecar on `localhost:3500`. Dapr handles routing across namespaces.

```
Your app → Your Dapr sidecar → Jurgen's Dapr sidecar → Jurgen's app
```

## What to add to Program.cs

Copy the two endpoints below into your `src/WorkshopApp/Program.cs`,
below the existing endpoints.

See [Program.cs](./Program.cs) for the complete example.

## How to test

Once deployed, open your app in the browser:

| URL | What it does |
|-----|-------------|
| `https://<yourname>.kubernetes.soulsseeker.com/hello` | Returns a greeting from your pod |
| `https://<yourname>.kubernetes.soulsseeker.com/call/jurgen` | Calls Jurgen's `/hello` via Dapr and returns his response |

Try calling each other's pods once everyone is deployed!
