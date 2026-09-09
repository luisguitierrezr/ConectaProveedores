namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TabsOptionalConfigs (fwVsPT8rhECdCQd26_Um1g)
///  <code>ST_e3f9af4171d5e4a41700770295d05c77Structure</code> that represent
/// s <code>TabsOptionalConfigs</code> <p>Description: Group of optional configurations for the Tabs
///  block.</p>
/// </summary>
// Name: TabsOptionalConfigs
public partial struct ST_e3f9af4171d5e4a41700770295d05c77Structure : ITypedRecord<ST_e3f9af4171d5e4a41700770295d05c77Structure> {
internal static readonly GlobalObjectKey IdContentAutoHeight = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*8bGI2iaVrUqrT7aimulLJQ");
internal static readonly GlobalObjectKey IdJustifyHeaders = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*mRGzTXqL_EqL5DbtO0o33A");

public bool ssContentAutoHeight;

public bool ssJustifyHeaders;


public BitArray OptimizedAttributes;

public ST_e3f9af4171d5e4a41700770295d05c77Structure() {
OptimizedAttributes = null;
ssContentAutoHeight = false;
ssJustifyHeaders = false;
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
ssContentAutoHeight = r.ReadBoolean(index++, "TabsOptionalConfigs.ContentAutoHeight", false);
ssJustifyHeaders = r.ReadBoolean(index++, "TabsOptionalConfigs.JustifyHeaders", false);
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
public void ReadIM(ST_e3f9af4171d5e4a41700770295d05c77Structure r) {
this = r;
}


public static bool operator == (ST_e3f9af4171d5e4a41700770295d05c77Structure a, ST_e3f9af4171d5e4a41700770295d05c77Structure b) {
if (a.ssContentAutoHeight != b.ssContentAutoHeight) return false;
if (a.ssJustifyHeaders != b.ssJustifyHeaders) return false;
return true;
}

public static bool operator != (ST_e3f9af4171d5e4a41700770295d05c77Structure a, ST_e3f9af4171d5e4a41700770295d05c77Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_e3f9af4171d5e4a41700770295d05c77Structure)) return false;
return (this == (ST_e3f9af4171d5e4a41700770295d05c77Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssContentAutoHeight.GetHashCode()
 ^ ssJustifyHeaders.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_e3f9af4171d5e4a41700770295d05c77Structure Duplicate() {
ST_e3f9af4171d5e4a41700770295d05c77Structure t;
t.ssContentAutoHeight = this.ssContentAutoHeight;
t.ssJustifyHeaders = this.ssJustifyHeaders;
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
if (head == "contentautoheight") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ContentAutoHeight")) variable.Value = ssContentAutoHeight; else variable.Optimized = true;
} else if (head == "justifyheaders") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".JustifyHeaders")) variable.Value = ssJustifyHeaders; else variable.Optimized = true;
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
if (key == IdContentAutoHeight) {
return ssContentAutoHeight;
}
if (key == IdJustifyHeaders) {
return ssJustifyHeaders;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdContentAutoHeight.Key.AsGuid) {
return ssContentAutoHeight;
}
if (attributeKey == IdJustifyHeaders.Key.AsGuid) {
return ssJustifyHeaders;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssContentAutoHeight = (bool) other.AttributeGet(IdContentAutoHeight);
ssJustifyHeaders = (bool) other.AttributeGet(IdJustifyHeaders);
}
} // ST_e3f9af4171d5e4a41700770295d05c77Structure
/// <summary>
/// RecordList type <code>TabsOptionalConfigsList</code> that represents a record list of
///  <code>TabsOptionalConfigs</code>
/// </summary>
public partial class RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc : GenericRecordList<ST_e3f9af4171d5e4a41700770295d05c77Structure>, IEnumerable, IEnumerator {

protected override ST_e3f9af4171d5e4a41700770295d05c77Structure GetElementDefaultValue() {
return new ST_e3f9af4171d5e4a41700770295d05c77Structure();
}

public T[] ToArray<T>(Func<ST_e3f9af4171d5e4a41700770295d05c77Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc recordList, Func<ST_e3f9af4171d5e4a41700770295d05c77Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc(ST_e3f9af4171d5e4a41700770295d05c77Structure[] array) {
  RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc result = new RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc();
result.InnerFromArray(array);
    return result;
}

public static RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc ToList<T>(T[] array, Func <T, ST_e3f9af4171d5e4a41700770295d05c77Structure> converter) {
  RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc result = new RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc FromRestList<T>(RestList<T> restList, Func <T, ST_e3f9af4171d5e4a41700770295d05c77Structure> converter) {
  RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc result = new RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_e3f9af4171d5e4a41700770295d05c77Structure> NewList() {
return new RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc();
}


} // RL_b3e25f2f8271a63fcdf2ac5b5ce11cdc
}

