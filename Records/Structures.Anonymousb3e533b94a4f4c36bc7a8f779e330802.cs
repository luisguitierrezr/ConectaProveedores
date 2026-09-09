namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (uTPls09KNky8eo93njMIAg)
///  <code>RC_e7c96643ac320a01471372d3fdec9c1e</code> that represent
/// s <code>UserUser_Extended_InternalDepartmentTelcelDirectionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUser_Extended_InternalDepartmentTelcelDirectionRecord
public partial struct RC_e7c96643ac320a01471372d3fdec9c1e : ITypedRecord<RC_e7c96643ac320a01471372d3fdec9c1e> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdDepartment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IzSRoKR0M7PMRMnTx82Mqg");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GJPF90MHwEDiMLq9XqYvtQ");

public ENUserEntityRecord ssENUser;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord ssENDepartment;

public EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord ssENTelcelDirection;


public BitArray OptimizedAttributes;

public RC_e7c96643ac320a01471372d3fdec9c1e() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENDepartment = new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord();
ssENTelcelDirection = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENDepartment.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUser_Extended_Internal.OptimizedAttributes = value[1];
    ssENDepartment.OptimizedAttributes = value[2];
    ssENTelcelDirection.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[2] = ssENDepartment.OptimizedAttributes;
    all[3] = ssENTelcelDirection.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENUser_Extended_Internal.Read( r, ref index);
ssENDepartment.Read( r, ref index);
ssENTelcelDirection.Read( r, ref index);
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
public void ReadIM(RC_e7c96643ac320a01471372d3fdec9c1e r) {
this = r;
}


public static bool operator == (RC_e7c96643ac320a01471372d3fdec9c1e a, RC_e7c96643ac320a01471372d3fdec9c1e b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENDepartment != b.ssENDepartment) return false;
if (a.ssENTelcelDirection != b.ssENTelcelDirection) return false;
return true;
}

public static bool operator != (RC_e7c96643ac320a01471372d3fdec9c1e a, RC_e7c96643ac320a01471372d3fdec9c1e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_e7c96643ac320a01471372d3fdec9c1e)) return false;
return (this == (RC_e7c96643ac320a01471372d3fdec9c1e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENDepartment.GetHashCode()
 ^ ssENTelcelDirection.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENDepartment.RecursiveReset();
ssENTelcelDirection.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENDepartment.InternalRecursiveSave();
ssENTelcelDirection.InternalRecursiveSave();
}


public RC_e7c96643ac320a01471372d3fdec9c1e Duplicate() {
RC_e7c96643ac320a01471372d3fdec9c1e t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENDepartment = (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord)this.ssENDepartment.Duplicate();
t.ssENTelcelDirection = (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord)this.ssENTelcelDirection.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
} else if (head == "department") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Department")) variable.Value = ssENDepartment; else variable.Optimized = true;
variable.SetFieldName("department");
} else if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssENTelcelDirection; else variable.Optimized = true;
variable.SetFieldName("telceldirection");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdDepartment) {
return ssENDepartment;
}
if (key == IdTelcelDirection) {
return ssENTelcelDirection;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdDepartment.Key.AsGuid) {
return ssENDepartment;
}
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssENTelcelDirection;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENDepartment.FillFromOther((IRecord) other.AttributeGet(IdDepartment));
ssENTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdTelcelDirection));
}
} // RC_e7c96643ac320a01471372d3fdec9c1e
/// <summary>
/// RecordList type <code>UserUser_Extended_InternalDepartmentTelcelDirectionRecordList</code> that
///  represents a record list of <code>User, User_Extended_Internal, Department, TelcelDirection</code>
/// </summary>
public partial class RL_324fa1265a392847ccc93fec110b2400 : GenericRecordList<RC_e7c96643ac320a01471372d3fdec9c1e>, IEnumerable, IEnumerator {

protected override RC_e7c96643ac320a01471372d3fdec9c1e GetElementDefaultValue() {
return new RC_e7c96643ac320a01471372d3fdec9c1e();
}

public T[] ToArray<T>(Func<RC_e7c96643ac320a01471372d3fdec9c1e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_324fa1265a392847ccc93fec110b2400 recordList, Func<RC_e7c96643ac320a01471372d3fdec9c1e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_324fa1265a392847ccc93fec110b2400(RC_e7c96643ac320a01471372d3fdec9c1e[] array) {
  RL_324fa1265a392847ccc93fec110b2400 result = new RL_324fa1265a392847ccc93fec110b2400();
result.InnerFromArray(array);
    return result;
}

public static RL_324fa1265a392847ccc93fec110b2400 ToList<T>(T[] array, Func <T, RC_e7c96643ac320a01471372d3fdec9c1e> converter) {
  RL_324fa1265a392847ccc93fec110b2400 result = new RL_324fa1265a392847ccc93fec110b2400();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_324fa1265a392847ccc93fec110b2400 FromRestList<T>(RestList<T> restList, Func <T, RC_e7c96643ac320a01471372d3fdec9c1e> converter) {
  RL_324fa1265a392847ccc93fec110b2400 result = new RL_324fa1265a392847ccc93fec110b2400();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_324fa1265a392847ccc93fec110b2400() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_e7c96643ac320a01471372d3fdec9c1e> NewList() {
return new RL_324fa1265a392847ccc93fec110b2400();
}


} // RL_324fa1265a392847ccc93fec110b2400
}

