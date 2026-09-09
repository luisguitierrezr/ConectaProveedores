namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pixeU51cqU60dg7DNG14Ww)
///  <code>RC_ceec47435de563c2690b605ecca69a94</code> that represents <code>ApplicationRoleRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ApplicationRoleRecord
public partial struct RC_ceec47435de563c2690b605ecca69a94 : ITypedRecord<RC_ceec47435de563c2690b605ecca69a94> {
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public static implicit operator EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord( RC_ceec47435de563c2690b605ecca69a94 r) {
return r.ssENApplicationRole;
}

public static implicit operator RC_ceec47435de563c2690b605ecca69a94 (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord r) {
RC_ceec47435de563c2690b605ecca69a94 res = new RC_ceec47435de563c2690b605ecca69a94 ();
res.ssENApplicationRole = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENApplicationRole.ChangedAttributes = value;
}
get {
    return ssENApplicationRole.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ceec47435de563c2690b605ecca69a94() {
OptimizedAttributes = null;
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENApplicationRole.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENApplicationRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENApplicationRole.Read( r, ref index);
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
public void ReadIM(RC_ceec47435de563c2690b605ecca69a94 r) {
this = r;
}


public static bool operator == (RC_ceec47435de563c2690b605ecca69a94 a, RC_ceec47435de563c2690b605ecca69a94 b) {
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_ceec47435de563c2690b605ecca69a94 a, RC_ceec47435de563c2690b605ecca69a94 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ceec47435de563c2690b605ecca69a94)) return false;
return (this == (RC_ceec47435de563c2690b605ecca69a94)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApplicationRole.InternalRecursiveSave();
}


public RC_ceec47435de563c2690b605ecca69a94 Duplicate() {
RC_ceec47435de563c2690b605ecca69a94 t;
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
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
if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENApplicationRole.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENApplicationRole.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_ceec47435de563c2690b605ecca69a94
/// <summary>
/// RecordList type <code>ApplicationRoleRecordList</code> that represents a record list of
///  <code>ApplicationRole</code>
/// </summary>
public partial class RL_2fd4ee9249069fb78258eb73022e4cb9 : GenericRecordList<RC_ceec47435de563c2690b605ecca69a94>, IEnumerable, IEnumerator {

protected override RC_ceec47435de563c2690b605ecca69a94 GetElementDefaultValue() {
return new RC_ceec47435de563c2690b605ecca69a94();
}

public T[] ToArray<T>(Func<RC_ceec47435de563c2690b605ecca69a94, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2fd4ee9249069fb78258eb73022e4cb9 recordList, Func<RC_ceec47435de563c2690b605ecca69a94, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2fd4ee9249069fb78258eb73022e4cb9(RC_ceec47435de563c2690b605ecca69a94[] array) {
  RL_2fd4ee9249069fb78258eb73022e4cb9 result = new RL_2fd4ee9249069fb78258eb73022e4cb9();
result.InnerFromArray(array);
    return result;
}

public static RL_2fd4ee9249069fb78258eb73022e4cb9 ToList<T>(T[] array, Func <T, RC_ceec47435de563c2690b605ecca69a94> converter) {
  RL_2fd4ee9249069fb78258eb73022e4cb9 result = new RL_2fd4ee9249069fb78258eb73022e4cb9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2fd4ee9249069fb78258eb73022e4cb9 FromRestList<T>(RestList<T> restList, Func <T, RC_ceec47435de563c2690b605ecca69a94> converter) {
  RL_2fd4ee9249069fb78258eb73022e4cb9 result = new RL_2fd4ee9249069fb78258eb73022e4cb9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2fd4ee9249069fb78258eb73022e4cb9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ceec47435de563c2690b605ecca69a94> NewList() {
return new RL_2fd4ee9249069fb78258eb73022e4cb9();
}


} // RL_2fd4ee9249069fb78258eb73022e4cb9
}

