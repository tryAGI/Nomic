dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Nomic \
  --clientClassName NomicClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
