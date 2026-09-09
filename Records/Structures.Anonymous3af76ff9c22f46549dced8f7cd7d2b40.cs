namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+W_3Oi_CVEadztj3zX0rQA)
///  <code>RC_9c083bb252b911414014156336301f46</code> that represent
/// s <code>OrderRequestFileStructRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileStructRecord
public partial struct RC_9c083bb252b911414014156336301f46 : ITypedRecord<RC_9c083bb252b911414014156336301f46> {
internal static readonly GlobalObjectKey IdOrderRequestFileStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sjsInLlSQRFAFBVjNjAfRg");

public ST_d9010d115c38fb059bccbc457fe11b18Structure ssSTOrderRequestFileStruct;


public static implicit operator ST_d9010d115c38fb059bccbc457fe11b18Structure( RC_9c083bb252b911414014156336301f46 r) {
return r.ssSTOrderRequestFileStruct;
}

public static implicit operator RC_9c083bb252b911414014156336301f46 (ST_d9010d115c38fb059bccbc457fe11b18Structure r) {
RC_9c083bb252b911414014156336301f46 res = new RC_9c083bb252b911414014156336301f46 ();
res.ssSTOrderRequestFileStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_9c083bb252b911414014156336301f46() {
OptimizedAttributes = null;
ssSTOrderRequestFileStruct = new ST_d9010d115c38fb059bccbc457fe11b18Structure();
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
    ssSTOrderRequestFileStruct.OptimizedAttributes = value[0];
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
ssSTOrderRequestFileStruct.Read( r, ref index);
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
public void ReadIM(RC_9c083bb252b911414014156336301f46 r) {
this = r;
}


public static bool operator == (RC_9c083bb252b911414014156336301f46 a, RC_9c083bb252b911414014156336301f46 b) {
if (a.ssSTOrderRequestFileStruct != b.ssSTOrderRequestFileStruct) return false;
return true;
}

public static bool operator != (RC_9c083bb252b911414014156336301f46 a, RC_9c083bb252b911414014156336301f46 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9c083bb252b911414014156336301f46)) return false;
return (this == (RC_9c083bb252b911414014156336301f46)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTOrderRequestFileStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTOrderRequestFileStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTOrderRequestFileStruct.InternalRecursiveSave();
}


public RC_9c083bb252b911414014156336301f46 Duplicate() {
RC_9c083bb252b911414014156336301f46 t;
t.ssSTOrderRequestFileStruct = (ST_d9010d115c38fb059bccbc457fe11b18Structure)this.ssSTOrderRequestFileStruct.Duplicate();
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
if (head == "orderrequestfilestruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileStruct")) variable.Value = ssSTOrderRequestFileStruct; else variable.Optimized = true;
variable.SetFieldName("orderrequestfilestruct");
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
if (key == IdOrderRequestFileStruct) {
return ssSTOrderRequestFileStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRequestFileStruct.Key.AsGuid) {
return ssSTOrderRequestFileStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTOrderRequestFileStruct.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileStruct));
}
} // RC_9c083bb252b911414014156336301f46
/// <summary>
/// RecordList type <code>OrderRequestFileStructRecordList</code> that represents a record list of
///  <code>OrderRequestFileStruct</code>
/// </summary>
public partial class RL_66fe2a4a682bec093701597db8b2fde3 : GenericRecordList<RC_9c083bb252b911414014156336301f46>, IEnumerable, IEnumerator {

protected override RC_9c083bb252b911414014156336301f46 GetElementDefaultValue() {
return new RC_9c083bb252b911414014156336301f46();
}

public T[] ToArray<T>(Func<RC_9c083bb252b911414014156336301f46, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_66fe2a4a682bec093701597db8b2fde3 recordList, Func<RC_9c083bb252b911414014156336301f46, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_66fe2a4a682bec093701597db8b2fde3(RC_9c083bb252b911414014156336301f46[] array) {
  RL_66fe2a4a682bec093701597db8b2fde3 result = new RL_66fe2a4a682bec093701597db8b2fde3();
result.InnerFromArray(array);
    return result;
}

public static RL_66fe2a4a682bec093701597db8b2fde3 ToList<T>(T[] array, Func <T, RC_9c083bb252b911414014156336301f46> converter) {
  RL_66fe2a4a682bec093701597db8b2fde3 result = new RL_66fe2a4a682bec093701597db8b2fde3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_66fe2a4a682bec093701597db8b2fde3 FromRestList<T>(RestList<T> restList, Func <T, RC_9c083bb252b911414014156336301f46> converter) {
  RL_66fe2a4a682bec093701597db8b2fde3 result = new RL_66fe2a4a682bec093701597db8b2fde3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_66fe2a4a682bec093701597db8b2fde3() : base() {
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
protected override OSList<RC_9c083bb252b911414014156336301f46> NewList() {
return new RL_66fe2a4a682bec093701597db8b2fde3();
}


} // RL_66fe2a4a682bec093701597db8b2fde3
}

