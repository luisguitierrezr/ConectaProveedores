namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (ZCiUCB7qp0+gIeqDCpmZ5g)
///  <code>RC_efc73b4c3b9559691917e7c2536af227</code> that represents <code>ProcessTypeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ProcessTypeRecord
public partial struct RC_efc73b4c3b9559691917e7c2536af227 : ITypedRecord<RC_efc73b4c3b9559691917e7c2536af227> {
internal static readonly GlobalObjectKey IdProcessType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*TDvH75U7aVkZF+fCU2ryJw");

public EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord ssENProcessType;


public static implicit operator EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord( RC_efc73b4c3b9559691917e7c2536af227 r) {
return r.ssENProcessType;
}

public static implicit operator RC_efc73b4c3b9559691917e7c2536af227 (EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord r) {
RC_efc73b4c3b9559691917e7c2536af227 res = new RC_efc73b4c3b9559691917e7c2536af227 ();
res.ssENProcessType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProcessType.ChangedAttributes = value;
}
get {
    return ssENProcessType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_efc73b4c3b9559691917e7c2536af227() {
OptimizedAttributes = null;
ssENProcessType = new EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProcessType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProcessType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProcessType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProcessType.Read( r, ref index);
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
public void ReadIM(RC_efc73b4c3b9559691917e7c2536af227 r) {
this = r;
}


public static bool operator == (RC_efc73b4c3b9559691917e7c2536af227 a, RC_efc73b4c3b9559691917e7c2536af227 b) {
if (a.ssENProcessType != b.ssENProcessType) return false;
return true;
}

public static bool operator != (RC_efc73b4c3b9559691917e7c2536af227 a, RC_efc73b4c3b9559691917e7c2536af227 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_efc73b4c3b9559691917e7c2536af227)) return false;
return (this == (RC_efc73b4c3b9559691917e7c2536af227)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProcessType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProcessType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProcessType.InternalRecursiveSave();
}


public RC_efc73b4c3b9559691917e7c2536af227 Duplicate() {
RC_efc73b4c3b9559691917e7c2536af227 t;
t.ssENProcessType = (EN_0ccf3a3356c3d304c812f79fccc130c7EntityRecord)this.ssENProcessType.Duplicate();
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
if (head == "processtype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ProcessType")) variable.Value = ssENProcessType; else variable.Optimized = true;
variable.SetFieldName("processtype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProcessType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProcessType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProcessType) {
return ssENProcessType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProcessType.Key.AsGuid) {
return ssENProcessType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProcessType.FillFromOther((IRecord) other.AttributeGet(IdProcessType));
}
} // RC_efc73b4c3b9559691917e7c2536af227
/// <summary>
/// RecordList type <code>ProcessTypeRecordList</code> that represents a record list of
///  <code>ProcessType</code>
/// </summary>
public partial class RL_50f86c7badf933578e482e000d347a03 : GenericRecordList<RC_efc73b4c3b9559691917e7c2536af227>, IEnumerable, IEnumerator {

protected override RC_efc73b4c3b9559691917e7c2536af227 GetElementDefaultValue() {
return new RC_efc73b4c3b9559691917e7c2536af227();
}

public T[] ToArray<T>(Func<RC_efc73b4c3b9559691917e7c2536af227, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_50f86c7badf933578e482e000d347a03 recordList, Func<RC_efc73b4c3b9559691917e7c2536af227, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_50f86c7badf933578e482e000d347a03(RC_efc73b4c3b9559691917e7c2536af227[] array) {
  RL_50f86c7badf933578e482e000d347a03 result = new RL_50f86c7badf933578e482e000d347a03();
result.InnerFromArray(array);
    return result;
}

public static RL_50f86c7badf933578e482e000d347a03 ToList<T>(T[] array, Func <T, RC_efc73b4c3b9559691917e7c2536af227> converter) {
  RL_50f86c7badf933578e482e000d347a03 result = new RL_50f86c7badf933578e482e000d347a03();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_50f86c7badf933578e482e000d347a03 FromRestList<T>(RestList<T> restList, Func <T, RC_efc73b4c3b9559691917e7c2536af227> converter) {
  RL_50f86c7badf933578e482e000d347a03 result = new RL_50f86c7badf933578e482e000d347a03();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_50f86c7badf933578e482e000d347a03() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_efc73b4c3b9559691917e7c2536af227> NewList() {
return new RL_50f86c7badf933578e482e000d347a03();
}


} // RL_50f86c7badf933578e482e000d347a03
}

