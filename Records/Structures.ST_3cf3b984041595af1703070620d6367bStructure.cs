namespace ssConectaProveedores {
/// <summary>
/// [CustomStructure] HTTPHeader (qfPVYTLjPESnU8rrj6GFVA)
///  <code>ST_3cf3b984041595af1703070620d6367bStructure</code> that represents <code>HTTPHeader</code
/// > <p>Description: </p>
/// </summary>
// Name: HTTPHeader
public partial struct ST_3cf3b984041595af1703070620d6367bStructure : ITypedRecord<ST_3cf3b984041595af1703070620d6367bStructure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QIkIlVxZkUKUAs27lj41bg");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*IjnKgzS2PkyUicSuOWxVhQ");

public string ssName;

public string ssValue;


public BitArray OptimizedAttributes;

public ST_3cf3b984041595af1703070620d6367bStructure() {
OptimizedAttributes = null;
ssName = "";
ssValue = "";
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
ssName = r.ReadText(index++, "HTTPHeader.Name", "");
ssValue = r.ReadText(index++, "HTTPHeader.Value", "");
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
public void ReadIM(ST_3cf3b984041595af1703070620d6367bStructure r) {
this = r;
}


public static bool operator == (ST_3cf3b984041595af1703070620d6367bStructure a, ST_3cf3b984041595af1703070620d6367bStructure b) {
if (a.ssName != b.ssName) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_3cf3b984041595af1703070620d6367bStructure a, ST_3cf3b984041595af1703070620d6367bStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3cf3b984041595af1703070620d6367bStructure)) return false;
return (this == (ST_3cf3b984041595af1703070620d6367bStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_3cf3b984041595af1703070620d6367bStructure Duplicate() {
ST_3cf3b984041595af1703070620d6367bStructure t;
t.ssName = this.ssName;
t.ssValue = this.ssValue;
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
if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
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
if (key == IdName) {
return ssName;
}
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssValue = (string) other.AttributeGet(IdValue);
}
} // ST_3cf3b984041595af1703070620d6367bStructure
/// <summary>
/// RecordList type <code>HTTPHeaderList</code> that represents a record list of
///  <code>HTTPHeader</code>
/// </summary>
public partial class RL_c06bca3d168b84039f4414ae52f271eb : GenericRecordList<ST_3cf3b984041595af1703070620d6367bStructure>, IEnumerable, IEnumerator {

protected override ST_3cf3b984041595af1703070620d6367bStructure GetElementDefaultValue() {
return new ST_3cf3b984041595af1703070620d6367bStructure();
}

public T[] ToArray<T>(Func<ST_3cf3b984041595af1703070620d6367bStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c06bca3d168b84039f4414ae52f271eb recordList, Func<ST_3cf3b984041595af1703070620d6367bStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c06bca3d168b84039f4414ae52f271eb(ST_3cf3b984041595af1703070620d6367bStructure[] array) {
  RL_c06bca3d168b84039f4414ae52f271eb result = new RL_c06bca3d168b84039f4414ae52f271eb();
result.InnerFromArray(array);
    return result;
}

public static RL_c06bca3d168b84039f4414ae52f271eb ToList<T>(T[] array, Func <T, ST_3cf3b984041595af1703070620d6367bStructure> converter) {
  RL_c06bca3d168b84039f4414ae52f271eb result = new RL_c06bca3d168b84039f4414ae52f271eb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c06bca3d168b84039f4414ae52f271eb FromRestList<T>(RestList<T> restList, Func <T, ST_3cf3b984041595af1703070620d6367bStructure> converter) {
  RL_c06bca3d168b84039f4414ae52f271eb result = new RL_c06bca3d168b84039f4414ae52f271eb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c06bca3d168b84039f4414ae52f271eb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3cf3b984041595af1703070620d6367bStructure> NewList() {
return new RL_c06bca3d168b84039f4414ae52f271eb();
}


} // RL_c06bca3d168b84039f4414ae52f271eb
}

