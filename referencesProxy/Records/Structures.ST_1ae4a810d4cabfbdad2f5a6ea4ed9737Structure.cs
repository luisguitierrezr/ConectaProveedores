namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] SeriesStylingOptionalConfigs (xKKapth8mEOwe6LjoAiuMg)
///  <code>ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure</code> that represent
/// s <code>SeriesStylingOptionalConfigs</code> <p>Description: Define the optional styles for a given
///  serie of the chart.</p>
/// </summary>
// Name: SeriesStylingOptionalConfigs
public partial struct ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure : ITypedRecord<ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure> {
internal static readonly GlobalObjectKey IdShowInLegend = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*_muoOGvcNEK0atQlOksFdg");
internal static readonly GlobalObjectKey IdxAxisId = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*jno0Phitf0+9nn66tMgFqg");
internal static readonly GlobalObjectKey IdyAxisId = GlobalObjectKey.Parse("Iw63OPxQEEeAzzaCqdyZig*wE8u+jqeLUKGdf8hvsC+Gg");

public bool ssShowInLegend;

public string ssxAxisId;

public string ssyAxisId;


public BitArray OptimizedAttributes;

public ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure() {
OptimizedAttributes = null;
ssShowInLegend = true;
ssxAxisId = RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_xAxisId;
ssyAxisId = RsseSpaceOutSystemsCharts.DefaultValues.ReferenceStructure_SeriesStylingOptionalConfigs_ReferenceStructureAttribute_yAxisId;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssShowInLegend = r.ReadBoolean(index++, "SeriesStylingOptionalConfigs.ShowInLegend", false);
ssxAxisId = r.ReadText(index++, "SeriesStylingOptionalConfigs.xAxisId", "");
ssyAxisId = r.ReadText(index++, "SeriesStylingOptionalConfigs.yAxisId", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure r) {
this = r;
}


public static bool operator == (ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure a, ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure b) {
if (a.ssShowInLegend != b.ssShowInLegend) return false;
if (a.ssxAxisId != b.ssxAxisId) return false;
if (a.ssyAxisId != b.ssyAxisId) return false;
return true;
}

public static bool operator != (ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure a, ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure)) return false;
return (this == (ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssShowInLegend.GetHashCode()
 ^ ssxAxisId.GetHashCode()
 ^ ssyAxisId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure Duplicate() {
ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure t;
t.ssShowInLegend = this.ssShowInLegend;
t.ssxAxisId = this.ssxAxisId;
t.ssyAxisId = this.ssyAxisId;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "showinlegend") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ShowInLegend")) variable.Value = ssShowInLegend; else variable.Optimized = true;
} else if (head == "xaxisid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".xAxisId")) variable.Value = ssxAxisId; else variable.Optimized = true;
} else if (head == "yaxisid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".yAxisId")) variable.Value = ssyAxisId; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdShowInLegend) {
return ssShowInLegend;
}
if (key == IdxAxisId) {
return ssxAxisId;
}
if (key == IdyAxisId) {
return ssyAxisId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdShowInLegend.Key.AsGuid) {
return ssShowInLegend;
}
if (attributeKey == IdxAxisId.Key.AsGuid) {
return ssxAxisId;
}
if (attributeKey == IdyAxisId.Key.AsGuid) {
return ssyAxisId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssShowInLegend = (bool) other.AttributeGet(IdShowInLegend);
ssxAxisId = (string) other.AttributeGet(IdxAxisId);
ssyAxisId = (string) other.AttributeGet(IdyAxisId);
}
} // ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure
/// <summary>
/// RecordList type <code>SeriesStylingOptionalConfigsList</code> that represents a record list of
///  <code>SeriesStylingOptionalConfigs</code>
/// </summary>
public partial class RL_ad52f40ed6b7fe5122edfaa0ea380f97 : GenericRecordList<ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure>, IEnumerable, IEnumerator {

protected override ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure GetElementDefaultValue() {
return new ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure();
}

public T[] ToArray<T>(Func<ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ad52f40ed6b7fe5122edfaa0ea380f97 recordList, Func<ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ad52f40ed6b7fe5122edfaa0ea380f97(ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure[] array) {
  RL_ad52f40ed6b7fe5122edfaa0ea380f97 result = new RL_ad52f40ed6b7fe5122edfaa0ea380f97();
result.InnerFromArray(array);
    return result;
}

public static RL_ad52f40ed6b7fe5122edfaa0ea380f97 ToList<T>(T[] array, Func <T, ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure> converter) {
  RL_ad52f40ed6b7fe5122edfaa0ea380f97 result = new RL_ad52f40ed6b7fe5122edfaa0ea380f97();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ad52f40ed6b7fe5122edfaa0ea380f97 FromRestList<T>(RestList<T> restList, Func <T, ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure> converter) {
  RL_ad52f40ed6b7fe5122edfaa0ea380f97 result = new RL_ad52f40ed6b7fe5122edfaa0ea380f97();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ad52f40ed6b7fe5122edfaa0ea380f97() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_1ae4a810d4cabfbdad2f5a6ea4ed9737Structure> NewList() {
return new RL_ad52f40ed6b7fe5122edfaa0ea380f97();
}


} // RL_ad52f40ed6b7fe5122edfaa0ea380f97
}

