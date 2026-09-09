namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (BzJxKP8xoEqW160ohLrvMA)
///  <code>RC_b29687471c7561fc031c1c100f2316ce</code> that represent
/// s <code>User_Extended_InternalDepartmentRecord</code> <p>Description: </p>
/// </summary>
// Name: User_Extended_InternalDepartmentRecord
public partial struct RC_b29687471c7561fc031c1c100f2316ce : ITypedRecord<RC_b29687471c7561fc031c1c100f2316ce> {
internal static readonly GlobalObjectKey IdUser_Extended_Internal = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ULR52TQNu52zesny_SptaA");
internal static readonly GlobalObjectKey IdDepartment = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*IzSRoKR0M7PMRMnTx82Mqg");

public EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord ssENUser_Extended_Internal;

public EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord ssENDepartment;


public BitArray OptimizedAttributes;

public RC_b29687471c7561fc031c1c100f2316ce() {
OptimizedAttributes = null;
ssENUser_Extended_Internal = new EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord();
ssENDepartment = new EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_Extended_Internal.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENDepartment.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENUser_Extended_Internal.OptimizedAttributes = value[0];
    ssENDepartment.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENUser_Extended_Internal.OptimizedAttributes;
    all[1] = ssENDepartment.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser_Extended_Internal.Read( r, ref index);
ssENDepartment.Read( r, ref index);
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
public void ReadIM(RC_b29687471c7561fc031c1c100f2316ce r) {
this = r;
}


public static bool operator == (RC_b29687471c7561fc031c1c100f2316ce a, RC_b29687471c7561fc031c1c100f2316ce b) {
if (a.ssENUser_Extended_Internal != b.ssENUser_Extended_Internal) return false;
if (a.ssENDepartment != b.ssENDepartment) return false;
return true;
}

public static bool operator != (RC_b29687471c7561fc031c1c100f2316ce a, RC_b29687471c7561fc031c1c100f2316ce b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b29687471c7561fc031c1c100f2316ce)) return false;
return (this == (RC_b29687471c7561fc031c1c100f2316ce)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_Extended_Internal.GetHashCode()
 ^ ssENDepartment.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser_Extended_Internal.RecursiveReset();
ssENDepartment.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_Extended_Internal.InternalRecursiveSave();
ssENDepartment.InternalRecursiveSave();
}


public RC_b29687471c7561fc031c1c100f2316ce Duplicate() {
RC_b29687471c7561fc031c1c100f2316ce t;
t.ssENUser_Extended_Internal = (EN_e34a6d7a1ac405a5f141259cb0cb005dEntityRecord)this.ssENUser_Extended_Internal.Duplicate();
t.ssENDepartment = (EN_6ab9a602282f97b31690e7c22fcf88b4EntityRecord)this.ssENDepartment.Duplicate();
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
if (head == "user_extended_internal") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Extended_Internal")) variable.Value = ssENUser_Extended_Internal; else variable.Optimized = true;
variable.SetFieldName("user_extended_internal");
} else if (head == "department") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Department")) variable.Value = ssENDepartment; else variable.Optimized = true;
variable.SetFieldName("department");
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
if (key == IdUser_Extended_Internal) {
return ssENUser_Extended_Internal;
}
if (key == IdDepartment) {
return ssENDepartment;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser_Extended_Internal.Key.AsGuid) {
return ssENUser_Extended_Internal;
}
if (attributeKey == IdDepartment.Key.AsGuid) {
return ssENDepartment;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser_Extended_Internal.FillFromOther((IRecord) other.AttributeGet(IdUser_Extended_Internal));
ssENDepartment.FillFromOther((IRecord) other.AttributeGet(IdDepartment));
}
} // RC_b29687471c7561fc031c1c100f2316ce
/// <summary>
/// RecordList type <code>User_Extended_InternalDepartmentRecordList</code> that represents a record
///  list of <code>User_Extended_Internal, Department</code>
/// </summary>
public partial class RL_e209cbb546a647ab2dbb42567bb25d19 : GenericRecordList<RC_b29687471c7561fc031c1c100f2316ce>, IEnumerable, IEnumerator {

protected override RC_b29687471c7561fc031c1c100f2316ce GetElementDefaultValue() {
return new RC_b29687471c7561fc031c1c100f2316ce();
}

public T[] ToArray<T>(Func<RC_b29687471c7561fc031c1c100f2316ce, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e209cbb546a647ab2dbb42567bb25d19 recordList, Func<RC_b29687471c7561fc031c1c100f2316ce, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e209cbb546a647ab2dbb42567bb25d19(RC_b29687471c7561fc031c1c100f2316ce[] array) {
  RL_e209cbb546a647ab2dbb42567bb25d19 result = new RL_e209cbb546a647ab2dbb42567bb25d19();
result.InnerFromArray(array);
    return result;
}

public static RL_e209cbb546a647ab2dbb42567bb25d19 ToList<T>(T[] array, Func <T, RC_b29687471c7561fc031c1c100f2316ce> converter) {
  RL_e209cbb546a647ab2dbb42567bb25d19 result = new RL_e209cbb546a647ab2dbb42567bb25d19();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e209cbb546a647ab2dbb42567bb25d19 FromRestList<T>(RestList<T> restList, Func <T, RC_b29687471c7561fc031c1c100f2316ce> converter) {
  RL_e209cbb546a647ab2dbb42567bb25d19 result = new RL_e209cbb546a647ab2dbb42567bb25d19();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e209cbb546a647ab2dbb42567bb25d19() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(20,false);
def[1] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b29687471c7561fc031c1c100f2316ce> NewList() {
return new RL_e209cbb546a647ab2dbb42567bb25d19();
}


} // RL_e209cbb546a647ab2dbb42567bb25d19
}

