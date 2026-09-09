namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (EPH7T9gRrEW+KuHcxt1NPw)
///  <code>RC_ab84a98a3ac9de80e9278e5b21681a23</code> that represents <code>TriggerRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TriggerRecord
public partial struct RC_ab84a98a3ac9de80e9278e5b21681a23 : ITypedRecord<RC_ab84a98a3ac9de80e9278e5b21681a23> {
internal static readonly GlobalObjectKey IdTrigger = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*iqmEq8k6gN7pJ45bIWgaIw");

public EN_52e55d60c515b6016f81404afb220594EntityRecord ssENTrigger;


public static implicit operator EN_52e55d60c515b6016f81404afb220594EntityRecord( RC_ab84a98a3ac9de80e9278e5b21681a23 r) {
return r.ssENTrigger;
}

public static implicit operator RC_ab84a98a3ac9de80e9278e5b21681a23 (EN_52e55d60c515b6016f81404afb220594EntityRecord r) {
RC_ab84a98a3ac9de80e9278e5b21681a23 res = new RC_ab84a98a3ac9de80e9278e5b21681a23 ();
res.ssENTrigger = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENTrigger.ChangedAttributes = value;
}
get {
    return ssENTrigger.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ab84a98a3ac9de80e9278e5b21681a23() {
OptimizedAttributes = null;
ssENTrigger = new EN_52e55d60c515b6016f81404afb220594EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENTrigger.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENTrigger.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENTrigger.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENTrigger.Read( r, ref index);
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
public void ReadIM(RC_ab84a98a3ac9de80e9278e5b21681a23 r) {
this = r;
}


public static bool operator == (RC_ab84a98a3ac9de80e9278e5b21681a23 a, RC_ab84a98a3ac9de80e9278e5b21681a23 b) {
if (a.ssENTrigger != b.ssENTrigger) return false;
return true;
}

public static bool operator != (RC_ab84a98a3ac9de80e9278e5b21681a23 a, RC_ab84a98a3ac9de80e9278e5b21681a23 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ab84a98a3ac9de80e9278e5b21681a23)) return false;
return (this == (RC_ab84a98a3ac9de80e9278e5b21681a23)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENTrigger.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENTrigger.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENTrigger.InternalRecursiveSave();
}


public RC_ab84a98a3ac9de80e9278e5b21681a23 Duplicate() {
RC_ab84a98a3ac9de80e9278e5b21681a23 t;
t.ssENTrigger = (EN_52e55d60c515b6016f81404afb220594EntityRecord)this.ssENTrigger.Duplicate();
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
if (head == "trigger") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Trigger")) variable.Value = ssENTrigger; else variable.Optimized = true;
variable.SetFieldName("trigger");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENTrigger.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENTrigger.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdTrigger) {
return ssENTrigger;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTrigger.Key.AsGuid) {
return ssENTrigger;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENTrigger.FillFromOther((IRecord) other.AttributeGet(IdTrigger));
}
} // RC_ab84a98a3ac9de80e9278e5b21681a23
/// <summary>
/// RecordList type <code>TriggerRecordList</code> that represents a record list of
///  <code>Trigger</code>
/// </summary>
public partial class RL_6534465d8eaff1ed770420b9742876dc : GenericRecordList<RC_ab84a98a3ac9de80e9278e5b21681a23>, IEnumerable, IEnumerator {

protected override RC_ab84a98a3ac9de80e9278e5b21681a23 GetElementDefaultValue() {
return new RC_ab84a98a3ac9de80e9278e5b21681a23();
}

public T[] ToArray<T>(Func<RC_ab84a98a3ac9de80e9278e5b21681a23, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6534465d8eaff1ed770420b9742876dc recordList, Func<RC_ab84a98a3ac9de80e9278e5b21681a23, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6534465d8eaff1ed770420b9742876dc(RC_ab84a98a3ac9de80e9278e5b21681a23[] array) {
  RL_6534465d8eaff1ed770420b9742876dc result = new RL_6534465d8eaff1ed770420b9742876dc();
result.InnerFromArray(array);
    return result;
}

public static RL_6534465d8eaff1ed770420b9742876dc ToList<T>(T[] array, Func <T, RC_ab84a98a3ac9de80e9278e5b21681a23> converter) {
  RL_6534465d8eaff1ed770420b9742876dc result = new RL_6534465d8eaff1ed770420b9742876dc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6534465d8eaff1ed770420b9742876dc FromRestList<T>(RestList<T> restList, Func <T, RC_ab84a98a3ac9de80e9278e5b21681a23> converter) {
  RL_6534465d8eaff1ed770420b9742876dc result = new RL_6534465d8eaff1ed770420b9742876dc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6534465d8eaff1ed770420b9742876dc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ab84a98a3ac9de80e9278e5b21681a23> NewList() {
return new RL_6534465d8eaff1ed770420b9742876dc();
}


} // RL_6534465d8eaff1ed770420b9742876dc
}

