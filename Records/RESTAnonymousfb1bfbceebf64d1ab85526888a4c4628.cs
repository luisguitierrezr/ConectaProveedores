using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TextText_2Record
public class RESTRC_8a1c045009e7a849632ad52d45f16812 : AbstractRESTStructure<RC_8a1c045009e7a849632ad52d45f16812> {
[JsonProperty("Text")]
public ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure AttrText;

[JsonProperty("Text_2")]
public ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure AttrText_2;

public RESTRC_8a1c045009e7a849632ad52d45f16812() { }

public RESTRC_8a1c045009e7a849632ad52d45f16812 (RC_8a1c045009e7a849632ad52d45f16812 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrText = ConvertToRestWithoutDefaults(s.ssSTText, new ST_1f76dfa138680efe9e5e11deb3c828b8Structure(), ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure, config);
AttrText_2 = ConvertToRestWithoutDefaults(s.ssSTText_2, new ST_1f76dfa138680efe9e5e11deb3c828b8Structure(), ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure, config);
  } else {
AttrText = ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure(s.ssSTText, config);
AttrText_2 = ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure.FromStructure(s.ssSTText_2, config);
  }
}

public static RC_8a1c045009e7a849632ad52d45f16812 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8a1c045009e7a849632ad52d45f16812 obj) { 
  RC_8a1c045009e7a849632ad52d45f16812 s = new RC_8a1c045009e7a849632ad52d45f16812();
  if(obj != null) {
  s.ssSTText = ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure.ToStructure(obj.AttrText);
  s.ssSTText_2 = ssConectaProveedores.RestRecords.RESTST_1f76dfa138680efe9e5e11deb3c828b8Structure.ToStructure(obj.AttrText_2);
  }
  return s;
}

public static Func<RC_8a1c045009e7a849632ad52d45f16812, ssConectaProveedores.RestRecords.RESTRC_8a1c045009e7a849632ad52d45f16812> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8a1c045009e7a849632ad52d45f16812 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8a1c045009e7a849632ad52d45f16812 FromStructure(RC_8a1c045009e7a849632ad52d45f16812 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8a1c045009e7a849632ad52d45f16812(s, config);
}

}


