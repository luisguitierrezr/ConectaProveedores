namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (fQLXK48bE0KVnIRUXqT_Ww)
///  <code>RC_7074703fd377ca40d733f2d5d8d3fde2</code> that represent
/// s <code>OrderApprovalOrderMainOrderApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderApprovalOrderMainOrderApprovalLevelRecord
public partial struct RC_7074703fd377ca40d733f2d5d8d3fde2 : ITypedRecord<RC_7074703fd377ca40d733f2d5d8d3fde2> {
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;


public BitArray OptimizedAttributes;

public RC_7074703fd377ca40d733f2d5d8d3fde2() {
OptimizedAttributes = null;
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(17,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderApproval.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENOrderApprovalLevel.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderApproval.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENOrderApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderApproval.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_7074703fd377ca40d733f2d5d8d3fde2 r) {
this = r;
}


public static bool operator == (RC_7074703fd377ca40d733f2d5d8d3fde2 a, RC_7074703fd377ca40d733f2d5d8d3fde2 b) {
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
return true;
}

public static bool operator != (RC_7074703fd377ca40d733f2d5d8d3fde2 a, RC_7074703fd377ca40d733f2d5d8d3fde2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7074703fd377ca40d733f2d5d8d3fde2)) return false;
return (this == (RC_7074703fd377ca40d733f2d5d8d3fde2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderApproval.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderApproval.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
}


public RC_7074703fd377ca40d733f2d5d8d3fde2 Duplicate() {
RC_7074703fd377ca40d733f2d5d8d3fde2 t;
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
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
if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
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
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
}
} // RC_7074703fd377ca40d733f2d5d8d3fde2
/// <summary>
/// RecordList type <code>OrderApprovalOrderMainOrderApprovalLevelRecordList</code> that represents a
///  record list of <code>OrderApproval, OrderMain, OrderApprovalLevel</code>
/// </summary>
public partial class RL_466c605dd07558761818d5a27c59c2b8 : GenericRecordList<RC_7074703fd377ca40d733f2d5d8d3fde2>, IEnumerable, IEnumerator {

protected override RC_7074703fd377ca40d733f2d5d8d3fde2 GetElementDefaultValue() {
return new RC_7074703fd377ca40d733f2d5d8d3fde2();
}

public T[] ToArray<T>(Func<RC_7074703fd377ca40d733f2d5d8d3fde2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_466c605dd07558761818d5a27c59c2b8 recordList, Func<RC_7074703fd377ca40d733f2d5d8d3fde2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_466c605dd07558761818d5a27c59c2b8(RC_7074703fd377ca40d733f2d5d8d3fde2[] array) {
  RL_466c605dd07558761818d5a27c59c2b8 result = new RL_466c605dd07558761818d5a27c59c2b8();
result.InnerFromArray(array);
    return result;
}

public static RL_466c605dd07558761818d5a27c59c2b8 ToList<T>(T[] array, Func <T, RC_7074703fd377ca40d733f2d5d8d3fde2> converter) {
  RL_466c605dd07558761818d5a27c59c2b8 result = new RL_466c605dd07558761818d5a27c59c2b8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_466c605dd07558761818d5a27c59c2b8 FromRestList<T>(RestList<T> restList, Func <T, RC_7074703fd377ca40d733f2d5d8d3fde2> converter) {
  RL_466c605dd07558761818d5a27c59c2b8 result = new RL_466c605dd07558761818d5a27c59c2b8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_466c605dd07558761818d5a27c59c2b8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(8,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(17,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7074703fd377ca40d733f2d5d8d3fde2> NewList() {
return new RL_466c605dd07558761818d5a27c59c2b8();
}


} // RL_466c605dd07558761818d5a27c59c2b8
}

