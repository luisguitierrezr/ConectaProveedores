namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (op6s8CtOik+eWdfZ8oFNwg)
///  <code>RC_a6a6e5f593e9e8b5f977af7779bd66f0</code> that represent
/// s <code>RequisitionList_StructRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionList_StructRecord
public partial struct RC_a6a6e5f593e9e8b5f977af7779bd66f0 : ITypedRecord<RC_a6a6e5f593e9e8b5f977af7779bd66f0> {
internal static readonly GlobalObjectKey IdRequisitionList_Struct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9eWmpumTtej5d693eb1m8A");

public ST_23b064f7387b135df7725dcd963884ceStructure ssSTRequisitionList_Struct;


public static implicit operator ST_23b064f7387b135df7725dcd963884ceStructure( RC_a6a6e5f593e9e8b5f977af7779bd66f0 r) {
return r.ssSTRequisitionList_Struct;
}

public static implicit operator RC_a6a6e5f593e9e8b5f977af7779bd66f0 (ST_23b064f7387b135df7725dcd963884ceStructure r) {
RC_a6a6e5f593e9e8b5f977af7779bd66f0 res = new RC_a6a6e5f593e9e8b5f977af7779bd66f0 ();
res.ssSTRequisitionList_Struct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_a6a6e5f593e9e8b5f977af7779bd66f0() {
OptimizedAttributes = null;
ssSTRequisitionList_Struct = new ST_23b064f7387b135df7725dcd963884ceStructure();
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
    ssSTRequisitionList_Struct.OptimizedAttributes = value[0];
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
ssSTRequisitionList_Struct.Read( r, ref index);
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
public void ReadIM(RC_a6a6e5f593e9e8b5f977af7779bd66f0 r) {
this = r;
}


public static bool operator == (RC_a6a6e5f593e9e8b5f977af7779bd66f0 a, RC_a6a6e5f593e9e8b5f977af7779bd66f0 b) {
if (a.ssSTRequisitionList_Struct != b.ssSTRequisitionList_Struct) return false;
return true;
}

public static bool operator != (RC_a6a6e5f593e9e8b5f977af7779bd66f0 a, RC_a6a6e5f593e9e8b5f977af7779bd66f0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a6a6e5f593e9e8b5f977af7779bd66f0)) return false;
return (this == (RC_a6a6e5f593e9e8b5f977af7779bd66f0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTRequisitionList_Struct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTRequisitionList_Struct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTRequisitionList_Struct.InternalRecursiveSave();
}


public RC_a6a6e5f593e9e8b5f977af7779bd66f0 Duplicate() {
RC_a6a6e5f593e9e8b5f977af7779bd66f0 t;
t.ssSTRequisitionList_Struct = (ST_23b064f7387b135df7725dcd963884ceStructure)this.ssSTRequisitionList_Struct.Duplicate();
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
if (head == "requisitionlist_struct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionList_Struct")) variable.Value = ssSTRequisitionList_Struct; else variable.Optimized = true;
variable.SetFieldName("requisitionlist_struct");
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
if (key == IdRequisitionList_Struct) {
return ssSTRequisitionList_Struct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionList_Struct.Key.AsGuid) {
return ssSTRequisitionList_Struct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTRequisitionList_Struct.FillFromOther((IRecord) other.AttributeGet(IdRequisitionList_Struct));
}
} // RC_a6a6e5f593e9e8b5f977af7779bd66f0
/// <summary>
/// RecordList type <code>RequisitionList_StructRecordList</code> that represents a record list of
///  <code>RequisitionList_Struct</code>
/// </summary>
public partial class RL_6afe7592bf936cbdcd13fc348b4ae3a3 : GenericRecordList<RC_a6a6e5f593e9e8b5f977af7779bd66f0>, IEnumerable, IEnumerator {

protected override RC_a6a6e5f593e9e8b5f977af7779bd66f0 GetElementDefaultValue() {
return new RC_a6a6e5f593e9e8b5f977af7779bd66f0();
}

public T[] ToArray<T>(Func<RC_a6a6e5f593e9e8b5f977af7779bd66f0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6afe7592bf936cbdcd13fc348b4ae3a3 recordList, Func<RC_a6a6e5f593e9e8b5f977af7779bd66f0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6afe7592bf936cbdcd13fc348b4ae3a3(RC_a6a6e5f593e9e8b5f977af7779bd66f0[] array) {
  RL_6afe7592bf936cbdcd13fc348b4ae3a3 result = new RL_6afe7592bf936cbdcd13fc348b4ae3a3();
result.InnerFromArray(array);
    return result;
}

public static RL_6afe7592bf936cbdcd13fc348b4ae3a3 ToList<T>(T[] array, Func <T, RC_a6a6e5f593e9e8b5f977af7779bd66f0> converter) {
  RL_6afe7592bf936cbdcd13fc348b4ae3a3 result = new RL_6afe7592bf936cbdcd13fc348b4ae3a3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6afe7592bf936cbdcd13fc348b4ae3a3 FromRestList<T>(RestList<T> restList, Func <T, RC_a6a6e5f593e9e8b5f977af7779bd66f0> converter) {
  RL_6afe7592bf936cbdcd13fc348b4ae3a3 result = new RL_6afe7592bf936cbdcd13fc348b4ae3a3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6afe7592bf936cbdcd13fc348b4ae3a3() : base() {
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
protected override OSList<RC_a6a6e5f593e9e8b5f977af7779bd66f0> NewList() {
return new RL_6afe7592bf936cbdcd13fc348b4ae3a3();
}


} // RL_6afe7592bf936cbdcd13fc348b4ae3a3
}

