namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (VE_XyUifukWe6NeY5gC25A)
///  <code>RC_2d3f02da87e3ed9a7fb846204a77cfbf</code> that represents <code>StepUsersRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: StepUsersRecord
public partial struct RC_2d3f02da87e3ed9a7fb846204a77cfbf : ITypedRecord<RC_2d3f02da87e3ed9a7fb846204a77cfbf> {
internal static readonly GlobalObjectKey IdStepUsers = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2gI_LeOHmu1_uEYgSnfPvw");

public ST_f14441a8387aba6d017931caef70dd11Structure ssSTStepUsers;


public static implicit operator ST_f14441a8387aba6d017931caef70dd11Structure( RC_2d3f02da87e3ed9a7fb846204a77cfbf r) {
return r.ssSTStepUsers;
}

public static implicit operator RC_2d3f02da87e3ed9a7fb846204a77cfbf (ST_f14441a8387aba6d017931caef70dd11Structure r) {
RC_2d3f02da87e3ed9a7fb846204a77cfbf res = new RC_2d3f02da87e3ed9a7fb846204a77cfbf ();
res.ssSTStepUsers = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_2d3f02da87e3ed9a7fb846204a77cfbf() {
OptimizedAttributes = null;
ssSTStepUsers = new ST_f14441a8387aba6d017931caef70dd11Structure();
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
    ssSTStepUsers.OptimizedAttributes = value[0];
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
ssSTStepUsers.Read( r, ref index);
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
public void ReadIM(RC_2d3f02da87e3ed9a7fb846204a77cfbf r) {
this = r;
}


public static bool operator == (RC_2d3f02da87e3ed9a7fb846204a77cfbf a, RC_2d3f02da87e3ed9a7fb846204a77cfbf b) {
if (a.ssSTStepUsers != b.ssSTStepUsers) return false;
return true;
}

public static bool operator != (RC_2d3f02da87e3ed9a7fb846204a77cfbf a, RC_2d3f02da87e3ed9a7fb846204a77cfbf b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2d3f02da87e3ed9a7fb846204a77cfbf)) return false;
return (this == (RC_2d3f02da87e3ed9a7fb846204a77cfbf)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTStepUsers.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTStepUsers.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTStepUsers.InternalRecursiveSave();
}


public RC_2d3f02da87e3ed9a7fb846204a77cfbf Duplicate() {
RC_2d3f02da87e3ed9a7fb846204a77cfbf t;
t.ssSTStepUsers = (ST_f14441a8387aba6d017931caef70dd11Structure)this.ssSTStepUsers.Duplicate();
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
if (head == "stepusers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".StepUsers")) variable.Value = ssSTStepUsers; else variable.Optimized = true;
variable.SetFieldName("stepusers");
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
if (key == IdStepUsers) {
return ssSTStepUsers;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStepUsers.Key.AsGuid) {
return ssSTStepUsers;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTStepUsers.FillFromOther((IRecord) other.AttributeGet(IdStepUsers));
}
} // RC_2d3f02da87e3ed9a7fb846204a77cfbf
/// <summary>
/// RecordList type <code>StepUsersRecordList</code> that represents a record list of
///  <code>StepUsers</code>
/// </summary>
public partial class RL_a16d85cb916177ea2c57857fe5644bbd : GenericRecordList<RC_2d3f02da87e3ed9a7fb846204a77cfbf>, IEnumerable, IEnumerator {

protected override RC_2d3f02da87e3ed9a7fb846204a77cfbf GetElementDefaultValue() {
return new RC_2d3f02da87e3ed9a7fb846204a77cfbf();
}

public T[] ToArray<T>(Func<RC_2d3f02da87e3ed9a7fb846204a77cfbf, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a16d85cb916177ea2c57857fe5644bbd recordList, Func<RC_2d3f02da87e3ed9a7fb846204a77cfbf, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a16d85cb916177ea2c57857fe5644bbd(RC_2d3f02da87e3ed9a7fb846204a77cfbf[] array) {
  RL_a16d85cb916177ea2c57857fe5644bbd result = new RL_a16d85cb916177ea2c57857fe5644bbd();
result.InnerFromArray(array);
    return result;
}

public static RL_a16d85cb916177ea2c57857fe5644bbd ToList<T>(T[] array, Func <T, RC_2d3f02da87e3ed9a7fb846204a77cfbf> converter) {
  RL_a16d85cb916177ea2c57857fe5644bbd result = new RL_a16d85cb916177ea2c57857fe5644bbd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a16d85cb916177ea2c57857fe5644bbd FromRestList<T>(RestList<T> restList, Func <T, RC_2d3f02da87e3ed9a7fb846204a77cfbf> converter) {
  RL_a16d85cb916177ea2c57857fe5644bbd result = new RL_a16d85cb916177ea2c57857fe5644bbd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a16d85cb916177ea2c57857fe5644bbd() : base() {
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
protected override OSList<RC_2d3f02da87e3ed9a7fb846204a77cfbf> NewList() {
return new RL_a16d85cb916177ea2c57857fe5644bbd();
}


} // RL_a16d85cb916177ea2c57857fe5644bbd
}

