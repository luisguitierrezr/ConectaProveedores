namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (fGh9aBSMNEmyQhAPweM_LQ)
///  <code>RC_3d56036e64426be06ca36c503a3c39e0</code> that represent
/// s <code>ApplicationRoleUserApplicationRoleTempByConceptUserApplicationRoleTempRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: ApplicationRoleUserApplicationRoleTempByConceptUserApplicationRoleTempRecord
public partial struct RC_3d56036e64426be06ca36c503a3c39e0 : ITypedRecord<RC_3d56036e64426be06ca36c503a3c39e0> {
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");
internal static readonly GlobalObjectKey IdUserApplicationRoleTempByConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xrXBCtF1LHQOp5eALuYlkg");
internal static readonly GlobalObjectKey IdUserApplicationRoleTemp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kn3GZlFuC4xnPZEZ9i2hkw");

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;

public EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord ssENUserApplicationRoleTempByConcept;

public EN_20bdea9cf8f17569719f414a83b584b6EntityRecord ssENUserApplicationRoleTemp;


public BitArray OptimizedAttributes;

public RC_3d56036e64426be06ca36c503a3c39e0() {
OptimizedAttributes = null;
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
ssENUserApplicationRoleTempByConcept = new EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord();
ssENUserApplicationRoleTemp = new EN_20bdea9cf8f17569719f414a83b584b6EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(7,false);
    all[1] = new BitArray(4,false);
    all[2] = new BitArray(14,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUserApplicationRoleTempByConcept.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENUserApplicationRoleTemp.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENApplicationRole.OptimizedAttributes = value[0];
    ssENUserApplicationRoleTempByConcept.OptimizedAttributes = value[1];
    ssENUserApplicationRoleTemp.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENApplicationRole.OptimizedAttributes;
    all[1] = ssENUserApplicationRoleTempByConcept.OptimizedAttributes;
    all[2] = ssENUserApplicationRoleTemp.OptimizedAttributes;
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
ssENUserApplicationRoleTempByConcept.Read( r, ref index);
ssENUserApplicationRoleTemp.Read( r, ref index);
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
public void ReadIM(RC_3d56036e64426be06ca36c503a3c39e0 r) {
this = r;
}


public static bool operator == (RC_3d56036e64426be06ca36c503a3c39e0 a, RC_3d56036e64426be06ca36c503a3c39e0 b) {
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
if (a.ssENUserApplicationRoleTempByConcept != b.ssENUserApplicationRoleTempByConcept) return false;
if (a.ssENUserApplicationRoleTemp != b.ssENUserApplicationRoleTemp) return false;
return true;
}

public static bool operator != (RC_3d56036e64426be06ca36c503a3c39e0 a, RC_3d56036e64426be06ca36c503a3c39e0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3d56036e64426be06ca36c503a3c39e0)) return false;
return (this == (RC_3d56036e64426be06ca36c503a3c39e0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
 ^ ssENUserApplicationRoleTempByConcept.GetHashCode()
 ^ ssENUserApplicationRoleTemp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENApplicationRole.RecursiveReset();
ssENUserApplicationRoleTempByConcept.RecursiveReset();
ssENUserApplicationRoleTemp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENApplicationRole.InternalRecursiveSave();
ssENUserApplicationRoleTempByConcept.InternalRecursiveSave();
ssENUserApplicationRoleTemp.InternalRecursiveSave();
}


public RC_3d56036e64426be06ca36c503a3c39e0 Duplicate() {
RC_3d56036e64426be06ca36c503a3c39e0 t;
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
t.ssENUserApplicationRoleTempByConcept = (EN_22cf7e5edc270b9d6ff62fe7b88e1c45EntityRecord)this.ssENUserApplicationRoleTempByConcept.Duplicate();
t.ssENUserApplicationRoleTemp = (EN_20bdea9cf8f17569719f414a83b584b6EntityRecord)this.ssENUserApplicationRoleTemp.Duplicate();
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
} else if (head == "userapplicationroletempbyconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRoleTempByConcept")) variable.Value = ssENUserApplicationRoleTempByConcept; else variable.Optimized = true;
variable.SetFieldName("userapplicationroletempbyconcept");
} else if (head == "userapplicationroletemp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".UserApplicationRoleTemp")) variable.Value = ssENUserApplicationRoleTemp; else variable.Optimized = true;
variable.SetFieldName("userapplicationroletemp");
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
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
if (key == IdUserApplicationRoleTempByConcept) {
return ssENUserApplicationRoleTempByConcept;
}
if (key == IdUserApplicationRoleTemp) {
return ssENUserApplicationRoleTemp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
if (attributeKey == IdUserApplicationRoleTempByConcept.Key.AsGuid) {
return ssENUserApplicationRoleTempByConcept;
}
if (attributeKey == IdUserApplicationRoleTemp.Key.AsGuid) {
return ssENUserApplicationRoleTemp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
ssENUserApplicationRoleTempByConcept.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRoleTempByConcept));
ssENUserApplicationRoleTemp.FillFromOther((IRecord) other.AttributeGet(IdUserApplicationRoleTemp));
}
} // RC_3d56036e64426be06ca36c503a3c39e0
/// <summary>
/// RecordList type
///  <code>ApplicationRoleUserApplicationRoleTempByConceptUserApplicationRoleTempRecordList</code> tha
/// t represents a record list of <code>ApplicationRole, UserApplicationRoleTempByConcept,
///  UserApplicationRoleTemp</code>
/// </summary>
public partial class RL_b9107f331631f30bcef7fe9d900d99ae : GenericRecordList<RC_3d56036e64426be06ca36c503a3c39e0>, IEnumerable, IEnumerator {

protected override RC_3d56036e64426be06ca36c503a3c39e0 GetElementDefaultValue() {
return new RC_3d56036e64426be06ca36c503a3c39e0();
}

public T[] ToArray<T>(Func<RC_3d56036e64426be06ca36c503a3c39e0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b9107f331631f30bcef7fe9d900d99ae recordList, Func<RC_3d56036e64426be06ca36c503a3c39e0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b9107f331631f30bcef7fe9d900d99ae(RC_3d56036e64426be06ca36c503a3c39e0[] array) {
  RL_b9107f331631f30bcef7fe9d900d99ae result = new RL_b9107f331631f30bcef7fe9d900d99ae();
result.InnerFromArray(array);
    return result;
}

public static RL_b9107f331631f30bcef7fe9d900d99ae ToList<T>(T[] array, Func <T, RC_3d56036e64426be06ca36c503a3c39e0> converter) {
  RL_b9107f331631f30bcef7fe9d900d99ae result = new RL_b9107f331631f30bcef7fe9d900d99ae();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b9107f331631f30bcef7fe9d900d99ae FromRestList<T>(RestList<T> restList, Func <T, RC_3d56036e64426be06ca36c503a3c39e0> converter) {
  RL_b9107f331631f30bcef7fe9d900d99ae result = new RL_b9107f331631f30bcef7fe9d900d99ae();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b9107f331631f30bcef7fe9d900d99ae() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(7,false);
def[1] = new BitArray(4,false);
def[2] = new BitArray(14,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3d56036e64426be06ca36c503a3c39e0> NewList() {
return new RL_b9107f331631f30bcef7fe9d900d99ae();
}


} // RL_b9107f331631f30bcef7fe9d900d99ae
}

