namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (cM_ItQuN80mWL6WbDhdauw)
///  <code>RC_26cbbaf47ee3c0155ebd57237529c97f</code> that represent
/// s <code>OrderMainOrderApprovaLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainOrderApprovaLevelRecord
public partial struct RC_26cbbaf47ee3c0155ebd57237529c97f : ITypedRecord<RC_26cbbaf47ee3c0155ebd57237529c97f> {
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdOrderApprovaLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qDtA5TM_uQ3kwDFO8UFBWg");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovaLevel;


public BitArray OptimizedAttributes;

public RC_26cbbaf47ee3c0155ebd57237529c97f() {
OptimizedAttributes = null;
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderApprovaLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(17,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderApprovaLevel.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderMain.OptimizedAttributes = value[0];
    ssENOrderApprovaLevel.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderMain.OptimizedAttributes;
    all[1] = ssENOrderApprovaLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMain.Read( r, ref index);
ssENOrderApprovaLevel.Read( r, ref index);
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
public void ReadIM(RC_26cbbaf47ee3c0155ebd57237529c97f r) {
this = r;
}


public static bool operator == (RC_26cbbaf47ee3c0155ebd57237529c97f a, RC_26cbbaf47ee3c0155ebd57237529c97f b) {
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENOrderApprovaLevel != b.ssENOrderApprovaLevel) return false;
return true;
}

public static bool operator != (RC_26cbbaf47ee3c0155ebd57237529c97f a, RC_26cbbaf47ee3c0155ebd57237529c97f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_26cbbaf47ee3c0155ebd57237529c97f)) return false;
return (this == (RC_26cbbaf47ee3c0155ebd57237529c97f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENOrderApprovaLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMain.RecursiveReset();
ssENOrderApprovaLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMain.InternalRecursiveSave();
ssENOrderApprovaLevel.InternalRecursiveSave();
}


public RC_26cbbaf47ee3c0155ebd57237529c97f Duplicate() {
RC_26cbbaf47ee3c0155ebd57237529c97f t;
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENOrderApprovaLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovaLevel.Duplicate();
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
if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "orderapprovalevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovaLevel")) variable.Value = ssENOrderApprovaLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovalevel");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdOrderApprovaLevel) {
return ssENOrderApprovaLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdOrderApprovaLevel.Key.AsGuid) {
return ssENOrderApprovaLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENOrderApprovaLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovaLevel));
}
} // RC_26cbbaf47ee3c0155ebd57237529c97f
/// <summary>
/// RecordList type <code>OrderMainOrderApprovaLevelRecordList</code> that represents a record list of
///  <code>OrderMain, OrderApprovalLevel</code>
/// </summary>
public partial class RL_e86d03b22fb6d164e868d40e92a28f1a : GenericRecordList<RC_26cbbaf47ee3c0155ebd57237529c97f>, IEnumerable, IEnumerator {

protected override RC_26cbbaf47ee3c0155ebd57237529c97f GetElementDefaultValue() {
return new RC_26cbbaf47ee3c0155ebd57237529c97f();
}

public T[] ToArray<T>(Func<RC_26cbbaf47ee3c0155ebd57237529c97f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e86d03b22fb6d164e868d40e92a28f1a recordList, Func<RC_26cbbaf47ee3c0155ebd57237529c97f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e86d03b22fb6d164e868d40e92a28f1a(RC_26cbbaf47ee3c0155ebd57237529c97f[] array) {
  RL_e86d03b22fb6d164e868d40e92a28f1a result = new RL_e86d03b22fb6d164e868d40e92a28f1a();
result.InnerFromArray(array);
    return result;
}

public static RL_e86d03b22fb6d164e868d40e92a28f1a ToList<T>(T[] array, Func <T, RC_26cbbaf47ee3c0155ebd57237529c97f> converter) {
  RL_e86d03b22fb6d164e868d40e92a28f1a result = new RL_e86d03b22fb6d164e868d40e92a28f1a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e86d03b22fb6d164e868d40e92a28f1a FromRestList<T>(RestList<T> restList, Func <T, RC_26cbbaf47ee3c0155ebd57237529c97f> converter) {
  RL_e86d03b22fb6d164e868d40e92a28f1a result = new RL_e86d03b22fb6d164e868d40e92a28f1a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e86d03b22fb6d164e868d40e92a28f1a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(29,false);
def[1] = new BitArray(17,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_26cbbaf47ee3c0155ebd57237529c97f> NewList() {
return new RL_e86d03b22fb6d164e868d40e92a28f1a();
}


} // RL_e86d03b22fb6d164e868d40e92a28f1a
}

