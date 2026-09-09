namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (djiNZV2cMEu_h41vrBjzgw)
///  <code>RC_0d776a4e191faf321030d5ce57aa4167</code> that represents <code>StepsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: StepsRecord
public partial struct RC_0d776a4e191faf321030d5ce57aa4167 : ITypedRecord<RC_0d776a4e191faf321030d5ce57aa4167> {
internal static readonly GlobalObjectKey IdSteps = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Tmp3DR8ZMq8QMNXOV6pBZw");

public EN_7441573ccf264d27ef548a39a846bd68EntityRecord ssENSteps;


public static implicit operator EN_7441573ccf264d27ef548a39a846bd68EntityRecord( RC_0d776a4e191faf321030d5ce57aa4167 r) {
return r.ssENSteps;
}

public static implicit operator RC_0d776a4e191faf321030d5ce57aa4167 (EN_7441573ccf264d27ef548a39a846bd68EntityRecord r) {
RC_0d776a4e191faf321030d5ce57aa4167 res = new RC_0d776a4e191faf321030d5ce57aa4167 ();
res.ssENSteps = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSteps.ChangedAttributes = value;
}
get {
    return ssENSteps.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_0d776a4e191faf321030d5ce57aa4167() {
OptimizedAttributes = null;
ssENSteps = new EN_7441573ccf264d27ef548a39a846bd68EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSteps.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSteps.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSteps.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSteps.Read( r, ref index);
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
public void ReadIM(RC_0d776a4e191faf321030d5ce57aa4167 r) {
this = r;
}


public static bool operator == (RC_0d776a4e191faf321030d5ce57aa4167 a, RC_0d776a4e191faf321030d5ce57aa4167 b) {
if (a.ssENSteps != b.ssENSteps) return false;
return true;
}

public static bool operator != (RC_0d776a4e191faf321030d5ce57aa4167 a, RC_0d776a4e191faf321030d5ce57aa4167 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0d776a4e191faf321030d5ce57aa4167)) return false;
return (this == (RC_0d776a4e191faf321030d5ce57aa4167)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSteps.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSteps.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSteps.InternalRecursiveSave();
}


public RC_0d776a4e191faf321030d5ce57aa4167 Duplicate() {
RC_0d776a4e191faf321030d5ce57aa4167 t;
t.ssENSteps = (EN_7441573ccf264d27ef548a39a846bd68EntityRecord)this.ssENSteps.Duplicate();
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
if (head == "steps") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Steps")) variable.Value = ssENSteps; else variable.Optimized = true;
variable.SetFieldName("steps");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSteps.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSteps.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSteps) {
return ssENSteps;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSteps.Key.AsGuid) {
return ssENSteps;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSteps.FillFromOther((IRecord) other.AttributeGet(IdSteps));
}
} // RC_0d776a4e191faf321030d5ce57aa4167
/// <summary>
/// RecordList type <code>StepsRecordList</code> that represents a record list of <code>Steps</code>
/// </summary>
public partial class RL_eaefbf6dde0f7f83dd46a12f58dd150a : GenericRecordList<RC_0d776a4e191faf321030d5ce57aa4167>, IEnumerable, IEnumerator {

protected override RC_0d776a4e191faf321030d5ce57aa4167 GetElementDefaultValue() {
return new RC_0d776a4e191faf321030d5ce57aa4167();
}

public T[] ToArray<T>(Func<RC_0d776a4e191faf321030d5ce57aa4167, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eaefbf6dde0f7f83dd46a12f58dd150a recordList, Func<RC_0d776a4e191faf321030d5ce57aa4167, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eaefbf6dde0f7f83dd46a12f58dd150a(RC_0d776a4e191faf321030d5ce57aa4167[] array) {
  RL_eaefbf6dde0f7f83dd46a12f58dd150a result = new RL_eaefbf6dde0f7f83dd46a12f58dd150a();
result.InnerFromArray(array);
    return result;
}

public static RL_eaefbf6dde0f7f83dd46a12f58dd150a ToList<T>(T[] array, Func <T, RC_0d776a4e191faf321030d5ce57aa4167> converter) {
  RL_eaefbf6dde0f7f83dd46a12f58dd150a result = new RL_eaefbf6dde0f7f83dd46a12f58dd150a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eaefbf6dde0f7f83dd46a12f58dd150a FromRestList<T>(RestList<T> restList, Func <T, RC_0d776a4e191faf321030d5ce57aa4167> converter) {
  RL_eaefbf6dde0f7f83dd46a12f58dd150a result = new RL_eaefbf6dde0f7f83dd46a12f58dd150a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eaefbf6dde0f7f83dd46a12f58dd150a() : base() {
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
protected override OSList<RC_0d776a4e191faf321030d5ce57aa4167> NewList() {
return new RL_eaefbf6dde0f7f83dd46a12f58dd150a();
}


} // RL_eaefbf6dde0f7f83dd46a12f58dd150a
}

