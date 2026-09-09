namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (A5jpitpYGkKAFQPw7DeTqw)
///  <code>RC_21a885f0bb9cdabb4dd12f34282bebba</code> that represent
/// s <code>UserUser_Extended_InternalDepartmentRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserUser_Extended_InternalDepartmentRegionRecord
public partial struct RC_21a885f0bb9cdabb4dd12f34282bebba : ITypedRecord<RC_21a885f0bb9cdabb4dd12f34282bebba> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdDepartment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IzSRoKR0M7PMRMnTx82Mqg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public ENUserEntityRecord ssENUser;

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord ssENDepartment;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_21a885f0bb9cdabb4dd12f34282bebba() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENDepartment = new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENDepartment.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENUser_Extended_Internal.OptimizedAttributes = value[1];
    ssENDepartment.OptimizedAttributes = value[2];
    ssENRegion.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[2] = ssENDepartment.OptimizedAttributes;
    all[3] = ssENRegion.OptimizedAttributes;
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
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_21a885f0bb9cdabb4dd12f34282bebba r) {
this = r;
}


public static bool operator == (RC_21a885f0bb9cdabb4dd12f34282bebba a, RC_21a885f0bb9cdabb4dd12f34282bebba b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENDepartment != b.ssENDepartment) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_21a885f0bb9cdabb4dd12f34282bebba a, RC_21a885f0bb9cdabb4dd12f34282bebba b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_21a885f0bb9cdabb4dd12f34282bebba)) return false;
return (this == (RC_21a885f0bb9cdabb4dd12f34282bebba)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENDepartment.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENUser_Extended_Internal.RecursiveReset();
ssENDepartment.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENDepartment.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_21a885f0bb9cdabb4dd12f34282bebba Duplicate() {
RC_21a885f0bb9cdabb4dd12f34282bebba t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENDepartment = (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord)this.ssENDepartment.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdRegion) {
return ssENRegion;
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
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENDepartment.FillFromOther((IRecord) other.AttributeGet(IdDepartment));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_21a885f0bb9cdabb4dd12f34282bebba
/// <summary>
/// RecordList type <code>UserUser_Extended_InternalDepartmentRegionRecordList</code> that represents a
///  record list of <code>User, User_Extended_Internal, Department, Region</code>
/// </summary>
public partial class RL_52a3075ea09fce1b2b3cbeb7d74742be : GenericRecordList<RC_21a885f0bb9cdabb4dd12f34282bebba>, IEnumerable, IEnumerator {

protected override RC_21a885f0bb9cdabb4dd12f34282bebba GetElementDefaultValue() {
return new RC_21a885f0bb9cdabb4dd12f34282bebba();
}

public T[] ToArray<T>(Func<RC_21a885f0bb9cdabb4dd12f34282bebba, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_52a3075ea09fce1b2b3cbeb7d74742be recordList, Func<RC_21a885f0bb9cdabb4dd12f34282bebba, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_52a3075ea09fce1b2b3cbeb7d74742be(RC_21a885f0bb9cdabb4dd12f34282bebba[] array) {
  RL_52a3075ea09fce1b2b3cbeb7d74742be result = new RL_52a3075ea09fce1b2b3cbeb7d74742be();
result.InnerFromArray(array);
    return result;
}

public static RL_52a3075ea09fce1b2b3cbeb7d74742be ToList<T>(T[] array, Func <T, RC_21a885f0bb9cdabb4dd12f34282bebba> converter) {
  RL_52a3075ea09fce1b2b3cbeb7d74742be result = new RL_52a3075ea09fce1b2b3cbeb7d74742be();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_52a3075ea09fce1b2b3cbeb7d74742be FromRestList<T>(RestList<T> restList, Func <T, RC_21a885f0bb9cdabb4dd12f34282bebba> converter) {
  RL_52a3075ea09fce1b2b3cbeb7d74742be result = new RL_52a3075ea09fce1b2b3cbeb7d74742be();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_52a3075ea09fce1b2b3cbeb7d74742be() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_21a885f0bb9cdabb4dd12f34282bebba> NewList() {
return new RL_52a3075ea09fce1b2b3cbeb7d74742be();
}


} // RL_52a3075ea09fce1b2b3cbeb7d74742be
}

