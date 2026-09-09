namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (FyZglYHjukONdgQ9p9O3GA)
///  <code>RC_a34c029579f872c2fbb90741544ea7c6</code> that represent
/// s <code>VirtualSelectConfigsRecord</code> <p>Description: </p>
/// </summary>
// Name: VirtualSelectConfigsRecord
public partial struct RC_a34c029579f872c2fbb90741544ea7c6 : ITypedRecord<RC_a34c029579f872c2fbb90741544ea7c6> {
internal static readonly GlobalObjectKey IdVirtualSelectConfigs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*lQJMo_h5wnL7uQdBVE6nxg");

public ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure ssSTVirtualSelectConfigs;


public static implicit operator ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure( RC_a34c029579f872c2fbb90741544ea7c6 r) {
return r.ssSTVirtualSelectConfigs;
}

public static implicit operator RC_a34c029579f872c2fbb90741544ea7c6 (ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure r) {
RC_a34c029579f872c2fbb90741544ea7c6 res = new RC_a34c029579f872c2fbb90741544ea7c6 ();
res.ssSTVirtualSelectConfigs = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a34c029579f872c2fbb90741544ea7c6() {
OptimizedAttributes = null;
ssSTVirtualSelectConfigs = new ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTVirtualSelectConfigs.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTVirtualSelectConfigs.Read( r, ref index);
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
public void ReadIM(RC_a34c029579f872c2fbb90741544ea7c6 r) {
this = r;
}


public static bool operator == (RC_a34c029579f872c2fbb90741544ea7c6 a, RC_a34c029579f872c2fbb90741544ea7c6 b) {
if (a.ssSTVirtualSelectConfigs != b.ssSTVirtualSelectConfigs) return false;
return true;
}

public static bool operator != (RC_a34c029579f872c2fbb90741544ea7c6 a, RC_a34c029579f872c2fbb90741544ea7c6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a34c029579f872c2fbb90741544ea7c6)) return false;
return (this == (RC_a34c029579f872c2fbb90741544ea7c6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTVirtualSelectConfigs.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTVirtualSelectConfigs.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTVirtualSelectConfigs.InternalRecursiveSave();
}


public RC_a34c029579f872c2fbb90741544ea7c6 Duplicate() {
RC_a34c029579f872c2fbb90741544ea7c6 t;
t.ssSTVirtualSelectConfigs = (ST_ee4d16d56cd7c489ec094cc9fa0cd607Structure)this.ssSTVirtualSelectConfigs.Duplicate();
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
if (head == "virtualselectconfigs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".VirtualSelectConfigs")) variable.Value = ssSTVirtualSelectConfigs; else variable.Optimized = true;
variable.SetFieldName("virtualselectconfigs");
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
if (key == IdVirtualSelectConfigs) {
return ssSTVirtualSelectConfigs;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdVirtualSelectConfigs.Key.AsGuid) {
return ssSTVirtualSelectConfigs;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTVirtualSelectConfigs.FillFromOther((IRecord) other.AttributeGet(IdVirtualSelectConfigs));
}
} // RC_a34c029579f872c2fbb90741544ea7c6
/// <summary>
/// RecordList type <code>VirtualSelectConfigsRecordList</code> that represents a record list of
///  <code>VirtualSelectConfigs</code>
/// </summary>
public partial class RL_c485f9f483418f5379953cdc77acac73 : GenericRecordList<RC_a34c029579f872c2fbb90741544ea7c6>, IEnumerable, IEnumerator {

protected override RC_a34c029579f872c2fbb90741544ea7c6 GetElementDefaultValue() {
return new RC_a34c029579f872c2fbb90741544ea7c6();
}

public T[] ToArray<T>(Func<RC_a34c029579f872c2fbb90741544ea7c6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c485f9f483418f5379953cdc77acac73 recordList, Func<RC_a34c029579f872c2fbb90741544ea7c6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c485f9f483418f5379953cdc77acac73(RC_a34c029579f872c2fbb90741544ea7c6[] array) {
  RL_c485f9f483418f5379953cdc77acac73 result = new RL_c485f9f483418f5379953cdc77acac73();
result.InnerFromArray(array);
    return result;
}

public static RL_c485f9f483418f5379953cdc77acac73 ToList<T>(T[] array, Func <T, RC_a34c029579f872c2fbb90741544ea7c6> converter) {
  RL_c485f9f483418f5379953cdc77acac73 result = new RL_c485f9f483418f5379953cdc77acac73();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c485f9f483418f5379953cdc77acac73 FromRestList<T>(RestList<T> restList, Func <T, RC_a34c029579f872c2fbb90741544ea7c6> converter) {
  RL_c485f9f483418f5379953cdc77acac73 result = new RL_c485f9f483418f5379953cdc77acac73();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c485f9f483418f5379953cdc77acac73() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a34c029579f872c2fbb90741544ea7c6> NewList() {
return new RL_c485f9f483418f5379953cdc77acac73();
}


} // RL_c485f9f483418f5379953cdc77acac73
}

