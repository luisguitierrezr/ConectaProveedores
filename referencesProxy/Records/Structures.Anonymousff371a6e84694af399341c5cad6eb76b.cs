namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (bho3_2mE80qZNBxcrW63aw)
///  <code>RC_51f0b789ef77b4d6d4002737fb63bbb9</code> that represents <code>RoleConceptRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RoleConceptRecord
public partial struct RC_51f0b789ef77b4d6d4002737fb63bbb9 : ITypedRecord<RC_51f0b789ef77b4d6d4002737fb63bbb9> {
internal static readonly GlobalObjectKey IdRoleConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ibfwUXfv1rTUACc3+2O7uQ");

public EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord ssENRoleConcept;


public static implicit operator EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord( RC_51f0b789ef77b4d6d4002737fb63bbb9 r) {
return r.ssENRoleConcept;
}

public static implicit operator RC_51f0b789ef77b4d6d4002737fb63bbb9 (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord r) {
RC_51f0b789ef77b4d6d4002737fb63bbb9 res = new RC_51f0b789ef77b4d6d4002737fb63bbb9 ();
res.ssENRoleConcept = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRoleConcept.ChangedAttributes = value;
}
get {
    return ssENRoleConcept.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_51f0b789ef77b4d6d4002737fb63bbb9() {
OptimizedAttributes = null;
ssENRoleConcept = new EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRoleConcept.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRoleConcept.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRoleConcept.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRoleConcept.Read( r, ref index);
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
public void ReadIM(RC_51f0b789ef77b4d6d4002737fb63bbb9 r) {
this = r;
}


public static bool operator == (RC_51f0b789ef77b4d6d4002737fb63bbb9 a, RC_51f0b789ef77b4d6d4002737fb63bbb9 b) {
if (a.ssENRoleConcept != b.ssENRoleConcept) return false;
return true;
}

public static bool operator != (RC_51f0b789ef77b4d6d4002737fb63bbb9 a, RC_51f0b789ef77b4d6d4002737fb63bbb9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_51f0b789ef77b4d6d4002737fb63bbb9)) return false;
return (this == (RC_51f0b789ef77b4d6d4002737fb63bbb9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRoleConcept.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRoleConcept.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRoleConcept.InternalRecursiveSave();
}


public RC_51f0b789ef77b4d6d4002737fb63bbb9 Duplicate() {
RC_51f0b789ef77b4d6d4002737fb63bbb9 t;
t.ssENRoleConcept = (EN_77ae46bb58c1a7be39d9a1b304bdae01EntityRecord)this.ssENRoleConcept.Duplicate();
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
if (head == "roleconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RoleConcept")) variable.Value = ssENRoleConcept; else variable.Optimized = true;
variable.SetFieldName("roleconcept");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRoleConcept.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRoleConcept.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRoleConcept) {
return ssENRoleConcept;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRoleConcept.Key.AsGuid) {
return ssENRoleConcept;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRoleConcept.FillFromOther((IRecord) other.AttributeGet(IdRoleConcept));
}
} // RC_51f0b789ef77b4d6d4002737fb63bbb9
/// <summary>
/// RecordList type <code>RoleConceptRecordList</code> that represents a record list of
///  <code>RoleConcept</code>
/// </summary>
public partial class RL_80e61ae275e815c747718eee51b2b1b3 : GenericRecordList<RC_51f0b789ef77b4d6d4002737fb63bbb9>, IEnumerable, IEnumerator {

protected override RC_51f0b789ef77b4d6d4002737fb63bbb9 GetElementDefaultValue() {
return new RC_51f0b789ef77b4d6d4002737fb63bbb9();
}

public T[] ToArray<T>(Func<RC_51f0b789ef77b4d6d4002737fb63bbb9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_80e61ae275e815c747718eee51b2b1b3 recordList, Func<RC_51f0b789ef77b4d6d4002737fb63bbb9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_80e61ae275e815c747718eee51b2b1b3(RC_51f0b789ef77b4d6d4002737fb63bbb9[] array) {
  RL_80e61ae275e815c747718eee51b2b1b3 result = new RL_80e61ae275e815c747718eee51b2b1b3();
result.InnerFromArray(array);
    return result;
}

public static RL_80e61ae275e815c747718eee51b2b1b3 ToList<T>(T[] array, Func <T, RC_51f0b789ef77b4d6d4002737fb63bbb9> converter) {
  RL_80e61ae275e815c747718eee51b2b1b3 result = new RL_80e61ae275e815c747718eee51b2b1b3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_80e61ae275e815c747718eee51b2b1b3 FromRestList<T>(RestList<T> restList, Func <T, RC_51f0b789ef77b4d6d4002737fb63bbb9> converter) {
  RL_80e61ae275e815c747718eee51b2b1b3 result = new RL_80e61ae275e815c747718eee51b2b1b3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_80e61ae275e815c747718eee51b2b1b3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_51f0b789ef77b4d6d4002737fb63bbb9> NewList() {
return new RL_80e61ae275e815c747718eee51b2b1b3();
}


} // RL_80e61ae275e815c747718eee51b2b1b3
}

