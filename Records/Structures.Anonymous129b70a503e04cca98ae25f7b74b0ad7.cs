namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pXCbEuADykyYriX3t0sK1w)
///  <code>RC_b993edfaac62fcf2f3babee6c7847316</code> that represent
/// s <code>User_CreatedUser_UpdatedRequisitionRecord</code> <p>Description: </p>
/// </summary>
// Name: User_CreatedUser_UpdatedRequisitionRecord
public partial struct RC_b993edfaac62fcf2f3babee6c7847316 : ITypedRecord<RC_b993edfaac62fcf2f3babee6c7847316> {
internal static readonly GlobalObjectKey IdUser_Created = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*YSDVOOt3vO23fm93lmQ9cg");
internal static readonly GlobalObjectKey IdUser_Updated = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kR9oLTPk4SneMmXwqt3RQA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");

public ENUserEntityRecord ssENUser_Created;

public ENUserEntityRecord ssENUser_Updated;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;


public BitArray OptimizedAttributes;

public RC_b993edfaac62fcf2f3babee6c7847316() {
OptimizedAttributes = null;
ssENUser_Created = new ENUserEntityRecord();
ssENUser_Updated = new ENUserEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(5,false);
    all[2] = new BitArray(58,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser_Created.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENUser_Updated.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser_Created.OptimizedAttributes = value[0];
    ssENUser_Updated.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser_Created.OptimizedAttributes;
    all[1] = ssENUser_Updated.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser_Created.Read( r, ref index);
ssENUser_Updated.Read( r, ref index);
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_b993edfaac62fcf2f3babee6c7847316 r) {
this = r;
}


public static bool operator == (RC_b993edfaac62fcf2f3babee6c7847316 a, RC_b993edfaac62fcf2f3babee6c7847316 b) {
if (a.ssENUser_Created != b.ssENUser_Created) return false;
if (a.ssENUser_Updated != b.ssENUser_Updated) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
return true;
}

public static bool operator != (RC_b993edfaac62fcf2f3babee6c7847316 a, RC_b993edfaac62fcf2f3babee6c7847316 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b993edfaac62fcf2f3babee6c7847316)) return false;
return (this == (RC_b993edfaac62fcf2f3babee6c7847316)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser_Created.GetHashCode()
 ^ ssENUser_Updated.GetHashCode()
 ^ ssENRequisition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser_Created.RecursiveReset();
ssENUser_Updated.RecursiveReset();
ssENRequisition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser_Created.InternalRecursiveSave();
ssENUser_Updated.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
}


public RC_b993edfaac62fcf2f3babee6c7847316 Duplicate() {
RC_b993edfaac62fcf2f3babee6c7847316 t;
t.ssENUser_Created = (ENUserEntityRecord)this.ssENUser_Created.Duplicate();
t.ssENUser_Updated = (ENUserEntityRecord)this.ssENUser_Updated.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
if (head == "user_created") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Created")) variable.Value = ssENUser_Created; else variable.Optimized = true;
variable.SetFieldName("user_created");
} else if (head == "user_updated") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User_Updated")) variable.Value = ssENUser_Updated; else variable.Optimized = true;
variable.SetFieldName("user_updated");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdUser_Created) {
return ssENUser_Created;
}
if (key == IdUser_Updated) {
return ssENUser_Updated;
}
if (key == IdRequisition) {
return ssENRequisition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser_Created.Key.AsGuid) {
return ssENUser_Created;
}
if (attributeKey == IdUser_Updated.Key.AsGuid) {
return ssENUser_Updated;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser_Created.FillFromOther((IRecord) other.AttributeGet(IdUser_Created));
ssENUser_Updated.FillFromOther((IRecord) other.AttributeGet(IdUser_Updated));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
}
} // RC_b993edfaac62fcf2f3babee6c7847316
/// <summary>
/// RecordList type <code>User_CreatedUser_UpdatedRequisitionRecordList</code> that represents a record
///  list of <code>User, User, Requisition</code>
/// </summary>
public partial class RL_04a672cdadcf245af3641b3d2cc441e5 : GenericRecordList<RC_b993edfaac62fcf2f3babee6c7847316>, IEnumerable, IEnumerator {

protected override RC_b993edfaac62fcf2f3babee6c7847316 GetElementDefaultValue() {
return new RC_b993edfaac62fcf2f3babee6c7847316();
}

public T[] ToArray<T>(Func<RC_b993edfaac62fcf2f3babee6c7847316, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_04a672cdadcf245af3641b3d2cc441e5 recordList, Func<RC_b993edfaac62fcf2f3babee6c7847316, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_04a672cdadcf245af3641b3d2cc441e5(RC_b993edfaac62fcf2f3babee6c7847316[] array) {
  RL_04a672cdadcf245af3641b3d2cc441e5 result = new RL_04a672cdadcf245af3641b3d2cc441e5();
result.InnerFromArray(array);
    return result;
}

public static RL_04a672cdadcf245af3641b3d2cc441e5 ToList<T>(T[] array, Func <T, RC_b993edfaac62fcf2f3babee6c7847316> converter) {
  RL_04a672cdadcf245af3641b3d2cc441e5 result = new RL_04a672cdadcf245af3641b3d2cc441e5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_04a672cdadcf245af3641b3d2cc441e5 FromRestList<T>(RestList<T> restList, Func <T, RC_b993edfaac62fcf2f3babee6c7847316> converter) {
  RL_04a672cdadcf245af3641b3d2cc441e5 result = new RL_04a672cdadcf245af3641b3d2cc441e5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_04a672cdadcf245af3641b3d2cc441e5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(5,false);
def[2] = new BitArray(58,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b993edfaac62fcf2f3babee6c7847316> NewList() {
return new RL_04a672cdadcf245af3641b3d2cc441e5();
}


} // RL_04a672cdadcf245af3641b3d2cc441e5
}

