namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (eGDJxi8l702MfYThiEHpgA)
///  <code>RC_44a1416c6a0b117b6b7e5164f9d5147f</code> that represent
/// s <code>UserApplicationRoleRecord</code> <p>Description: </p>
/// </summary>
// Name: UserApplicationRoleRecord
public partial struct RC_44a1416c6a0b117b6b7e5164f9d5147f : ITypedRecord<RC_44a1416c6a0b117b6b7e5164f9d5147f> {
internal static readonly GlobalObjectKey IdUserApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bEGhRAtqexFrflFk+dUUfw");

public EN_d70717a411b3cebe926da612400b1467EntityRecord ssENUserApplicationRole;


public static implicit operator EN_d70717a411b3cebe926da612400b1467EntityRecord( RC_44a1416c6a0b117b6b7e5164f9d5147f r) {
return r.ssENUserApplicationRole;
}

public static implicit operator RC_44a1416c6a0b117b6b7e5164f9d5147f (EN_d70717a411b3cebe926da612400b1467EntityRecord r) {
RC_44a1416c6a0b117b6b7e5164f9d5147f res = new RC_44a1416c6a0b117b6b7e5164f9d5147f ();
res.ssENUserApplicationRole = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENUserApplicationRole.ChangedAttributes = value;
}
get {
    return ssENUserApplicationRole.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_44a1416c6a0b117b6b7e5164f9d5147f() {
OptimizedAttributes = null;
ssENUserApplicationRole = new EN_d70717a411b3cebe926da612400b1467EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUserApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENUserApplicationRole.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENUserApplicationRole.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUserApplicationRole.Read( r, ref index);
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
public void ReadIM(RC_44a1416c6a0b117b6b7e5164f9d5147f r) {
this = r;
}


public static bool operator == (RC_44a1416c6a0b117b6b7e5164f9d5147f a, RC_44a1416c6a0b117b6b7e5164f9d5147f b) {
if (a.ssENUserApplicationRole != b.ssENUserApplicationRole) return false;
return true;
}

public static bool operator != (RC_44a1416c6a0b117b6b7e5164f9d5147f a, RC_44a1416c6a0b117b6b7e5164f9d5147f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_44a1416c6a0b117b6b7e5164f9d5147f)) return false;
return (this == (RC_44a1416c6a0b117b6b7e5164f9d5147f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUserApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUserApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUserApplicationRole.InternalRecursiveSave();
}


public RC_44a1416c6a0b117b6b7e5164f9d5147f Duplicate() {
RC_44a1416c6a0b117b6b7e5164f9d5147f t;
t.ssENUserApplicationRole = (EN_d70717a411b3cebe926da612400b1467EntityRecord)this.ssENUserApplicationRole.Duplicate();
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
if (head == "userapplicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRole")) variable.Value = ssENUserApplicationRole; else variable.Optimized = true;
variable.SetFieldName("userapplicationrole");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENUserApplicationRole.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENUserApplicationRole.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdUserApplicationRole) {
return ssENUserApplicationRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUserApplicationRole.Key.AsGuid) {
return ssENUserApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUserApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRole));
}
} // RC_44a1416c6a0b117b6b7e5164f9d5147f
/// <summary>
/// RecordList type <code>UserApplicationRoleRecordList</code> that represents a record list of
///  <code>UserApplicationRole</code>
/// </summary>
public partial class RL_d22dbb34ff25b8803ae17b65f615d2c8 : GenericRecordList<RC_44a1416c6a0b117b6b7e5164f9d5147f>, IEnumerable, IEnumerator {

protected override RC_44a1416c6a0b117b6b7e5164f9d5147f GetElementDefaultValue() {
return new RC_44a1416c6a0b117b6b7e5164f9d5147f();
}

public T[] ToArray<T>(Func<RC_44a1416c6a0b117b6b7e5164f9d5147f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d22dbb34ff25b8803ae17b65f615d2c8 recordList, Func<RC_44a1416c6a0b117b6b7e5164f9d5147f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d22dbb34ff25b8803ae17b65f615d2c8(RC_44a1416c6a0b117b6b7e5164f9d5147f[] array) {
  RL_d22dbb34ff25b8803ae17b65f615d2c8 result = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
result.InnerFromArray(array);
    return result;
}

public static RL_d22dbb34ff25b8803ae17b65f615d2c8 ToList<T>(T[] array, Func <T, RC_44a1416c6a0b117b6b7e5164f9d5147f> converter) {
  RL_d22dbb34ff25b8803ae17b65f615d2c8 result = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d22dbb34ff25b8803ae17b65f615d2c8 FromRestList<T>(RestList<T> restList, Func <T, RC_44a1416c6a0b117b6b7e5164f9d5147f> converter) {
  RL_d22dbb34ff25b8803ae17b65f615d2c8 result = new RL_d22dbb34ff25b8803ae17b65f615d2c8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d22dbb34ff25b8803ae17b65f615d2c8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_44a1416c6a0b117b6b7e5164f9d5147f> NewList() {
return new RL_d22dbb34ff25b8803ae17b65f615d2c8();
}


} // RL_d22dbb34ff25b8803ae17b65f615d2c8
}

