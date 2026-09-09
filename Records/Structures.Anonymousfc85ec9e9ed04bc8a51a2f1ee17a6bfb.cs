namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (nuyF_NCeyEulGi8e4Xpr+w)
///  <code>RC_b93868933f6a016605b24812ac8e5133</code> that represent
/// s <code>OrderRequestFileApprovalOrderRequestFileApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderRequestFileApprovalOrderRequestFileApprovalLevelRecord
public partial struct RC_b93868933f6a016605b24812ac8e5133 : ITypedRecord<RC_b93868933f6a016605b24812ac8e5133> {
internal static readonly GlobalObjectKey IdOrderRequestFileApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*igvHZHI_KNE_GKPaj46z1Q");
internal static readonly GlobalObjectKey IdOrderRequestFileApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*CgSm2lumwlVXTmpOl2dmzg");

public EN_1710c672f4d7138b664ee1411114271eEntityRecord ssENOrderRequestFileApproval;

public EN_80af67ecab8f43d464cc57955285a024EntityRecord ssENOrderRequestFileApprovalLevel;


public BitArray OptimizedAttributes;

public RC_b93868933f6a016605b24812ac8e5133() {
OptimizedAttributes = null;
ssENOrderRequestFileApproval = new EN_1710c672f4d7138b664ee1411114271eEntityRecord();
ssENOrderRequestFileApprovalLevel = new EN_80af67ecab8f43d464cc57955285a024EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(12,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderRequestFileApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderRequestFileApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderRequestFileApproval.OptimizedAttributes = value[0];
    ssENOrderRequestFileApprovalLevel.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderRequestFileApproval.OptimizedAttributes;
    all[1] = ssENOrderRequestFileApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderRequestFileApproval.Read( r, ref index);
ssENOrderRequestFileApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_b93868933f6a016605b24812ac8e5133 r) {
this = r;
}


public static bool operator == (RC_b93868933f6a016605b24812ac8e5133 a, RC_b93868933f6a016605b24812ac8e5133 b) {
if (a.ssENOrderRequestFileApproval != b.ssENOrderRequestFileApproval) return false;
if (a.ssENOrderRequestFileApprovalLevel != b.ssENOrderRequestFileApprovalLevel) return false;
return true;
}

public static bool operator != (RC_b93868933f6a016605b24812ac8e5133 a, RC_b93868933f6a016605b24812ac8e5133 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b93868933f6a016605b24812ac8e5133)) return false;
return (this == (RC_b93868933f6a016605b24812ac8e5133)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderRequestFileApproval.GetHashCode()
 ^ ssENOrderRequestFileApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderRequestFileApproval.RecursiveReset();
ssENOrderRequestFileApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderRequestFileApproval.InternalRecursiveSave();
ssENOrderRequestFileApprovalLevel.InternalRecursiveSave();
}


public RC_b93868933f6a016605b24812ac8e5133 Duplicate() {
RC_b93868933f6a016605b24812ac8e5133 t;
t.ssENOrderRequestFileApproval = (EN_1710c672f4d7138b664ee1411114271eEntityRecord)this.ssENOrderRequestFileApproval.Duplicate();
t.ssENOrderRequestFileApprovalLevel = (EN_80af67ecab8f43d464cc57955285a024EntityRecord)this.ssENOrderRequestFileApprovalLevel.Duplicate();
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
if (head == "orderrequestfileapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileApproval")) variable.Value = ssENOrderRequestFileApproval; else variable.Optimized = true;
variable.SetFieldName("orderrequestfileapproval");
} else if (head == "orderrequestfileapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderRequestFileApprovalLevel")) variable.Value = ssENOrderRequestFileApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderrequestfileapprovallevel");
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
if (key == IdOrderRequestFileApproval) {
return ssENOrderRequestFileApproval;
}
if (key == IdOrderRequestFileApprovalLevel) {
return ssENOrderRequestFileApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderRequestFileApproval.Key.AsGuid) {
return ssENOrderRequestFileApproval;
}
if (attributeKey == IdOrderRequestFileApprovalLevel.Key.AsGuid) {
return ssENOrderRequestFileApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderRequestFileApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileApproval));
ssENOrderRequestFileApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderRequestFileApprovalLevel));
}
} // RC_b93868933f6a016605b24812ac8e5133
/// <summary>
/// RecordList type <code>OrderRequestFileApprovalOrderRequestFileApprovalLevelRecordList</code> that
///  represents a record list of <code>OrderRequestFileApproval, OrderRequestFileApprovalLevel</code>
/// </summary>
public partial class RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 : GenericRecordList<RC_b93868933f6a016605b24812ac8e5133>, IEnumerable, IEnumerator {

protected override RC_b93868933f6a016605b24812ac8e5133 GetElementDefaultValue() {
return new RC_b93868933f6a016605b24812ac8e5133();
}

public T[] ToArray<T>(Func<RC_b93868933f6a016605b24812ac8e5133, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 recordList, Func<RC_b93868933f6a016605b24812ac8e5133, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3c8cbdb9e0fe43bbb7aa86b8fa547000(RC_b93868933f6a016605b24812ac8e5133[] array) {
  RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 result = new RL_3c8cbdb9e0fe43bbb7aa86b8fa547000();
result.InnerFromArray(array);
    return result;
}

public static RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 ToList<T>(T[] array, Func <T, RC_b93868933f6a016605b24812ac8e5133> converter) {
  RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 result = new RL_3c8cbdb9e0fe43bbb7aa86b8fa547000();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 FromRestList<T>(RestList<T> restList, Func <T, RC_b93868933f6a016605b24812ac8e5133> converter) {
  RL_3c8cbdb9e0fe43bbb7aa86b8fa547000 result = new RL_3c8cbdb9e0fe43bbb7aa86b8fa547000();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3c8cbdb9e0fe43bbb7aa86b8fa547000() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(6,false);
def[1] = new BitArray(12,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b93868933f6a016605b24812ac8e5133> NewList() {
return new RL_3c8cbdb9e0fe43bbb7aa86b8fa547000();
}


} // RL_3c8cbdb9e0fe43bbb7aa86b8fa547000
}

