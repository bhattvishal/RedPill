<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="VB.RedPill.CloudHost" generation="1" functional="0" release="0" Id="d92e41d2-7b48-4107-a996-d5172ee17d15" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="VB.RedPill.CloudHostGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="VB.RedPill.WcfRole:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/VB.RedPill.CloudHost/VB.RedPill.CloudHostGroup/LB:VB.RedPill.WcfRole:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="VB.RedPill.WcfRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/VB.RedPill.CloudHost/VB.RedPill.CloudHostGroup/MapVB.RedPill.WcfRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="VB.RedPill.WcfRoleInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/VB.RedPill.CloudHost/VB.RedPill.CloudHostGroup/MapVB.RedPill.WcfRoleInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:VB.RedPill.WcfRole:Endpoint1">
          <toPorts>
            <inPortMoniker name="/VB.RedPill.CloudHost/VB.RedPill.CloudHostGroup/VB.RedPill.WcfRole/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapVB.RedPill.WcfRole:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/VB.RedPill.CloudHost/VB.RedPill.CloudHostGroup/VB.RedPill.WcfRole/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapVB.RedPill.WcfRoleInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/VB.RedPill.CloudHost/VB.RedPill.CloudHostGroup/VB.RedPill.WcfRoleInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="VB.RedPill.WcfRole" generation="1" functional="0" release="0" software="D:\Projects\TFSOnline\WebDevelopment\VB.RedPill\VB.RedPill.CloudHost\csx\Release\roles\VB.RedPill.WcfRole" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;VB.RedPill.WcfRole&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;VB.RedPill.WcfRole&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/VB.RedPill.CloudHost/VB.RedPill.CloudHostGroup/VB.RedPill.WcfRoleInstances" />
            <sCSPolicyUpdateDomainMoniker name="/VB.RedPill.CloudHost/VB.RedPill.CloudHostGroup/VB.RedPill.WcfRoleUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/VB.RedPill.CloudHost/VB.RedPill.CloudHostGroup/VB.RedPill.WcfRoleFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="VB.RedPill.WcfRoleUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="VB.RedPill.WcfRoleFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="VB.RedPill.WcfRoleInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="23c8e66d-d520-4339-a9e2-8793abd6870c" ref="Microsoft.RedDog.Contract\ServiceContract\VB.RedPill.CloudHostContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="e050e6fa-a0a5-47fd-a5d1-b2a961f03f7e" ref="Microsoft.RedDog.Contract\Interface\VB.RedPill.WcfRole:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/VB.RedPill.CloudHost/VB.RedPill.CloudHostGroup/VB.RedPill.WcfRole:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>