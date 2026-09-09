namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (DgzWWhA_mkm5INJh_t+ejQ)
///  <code>RC_0ac0129639ce616349f284f107640b9e</code> that represent
/// s <code>OrderStatusOrdersImportRequestOrderMainTelcelDirectionDivisionRegionRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: OrderStatusOrdersImportRequestOrderMainTelcelDirectionDivisionRegionRecord
public partial struct RC_0ac0129639ce616349f284f107640b9e : ITypedRecord<RC_0ac0129639ce616349f284f107640b9e> {
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrdersImportRequest = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*q7UHJMuyrv6qjabN6kzPEg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GJPF90MHwEDiMLq9XqYvtQ");
internal static readonly GlobalObjectKey IdDivision = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*5GESC1EOpUWUgJSAWPVtAA");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_8c3668a93870461b8ea1216c2848f298EntityRecord ssENOrdersImportRequest;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord ssENTelcelDirection;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENDivision;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_0ac0129639ce616349f284f107640b9e() {
OptimizedAttributes = null;
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrdersImportRequest = new EN_8c3668a93870461b8ea1216c2848f298EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENTelcelDirection = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
ssENDivision = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(7,false);
    all[4] = new BitArray(13,false);
    all[5] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrdersImportRequest.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENDivision.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENOrderStatus.OptimizedAttributes = value[0];
    ssENOrdersImportRequest.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENTelcelDirection.OptimizedAttributes = value[3];
    ssENDivision.OptimizedAttributes = value[4];
    ssENRegion.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENOrderStatus.OptimizedAttributes;
    all[1] = ssENOrdersImportRequest.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENTelcelDirection.OptimizedAttributes;
    all[4] = ssENDivision.OptimizedAttributes;
    all[5] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderStatus.Read( r, ref index);
ssENOrdersImportRequest.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENTelcelDirection.Read( r, ref index);
ssENDivision.Read( r, ref index);
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
public void ReadIM(RC_0ac0129639ce616349f284f107640b9e r) {
this = r;
}


public static bool operator == (RC_0ac0129639ce616349f284f107640b9e a, RC_0ac0129639ce616349f284f107640b9e b) {
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrdersImportRequest != b.ssENOrdersImportRequest) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENTelcelDirection != b.ssENTelcelDirection) return false;
if (a.ssENDivision != b.ssENDivision) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_0ac0129639ce616349f284f107640b9e a, RC_0ac0129639ce616349f284f107640b9e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0ac0129639ce616349f284f107640b9e)) return false;
return (this == (RC_0ac0129639ce616349f284f107640b9e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrdersImportRequest.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENTelcelDirection.GetHashCode()
 ^ ssENDivision.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderStatus.RecursiveReset();
ssENOrdersImportRequest.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENTelcelDirection.RecursiveReset();
ssENDivision.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderStatus.InternalRecursiveSave();
ssENOrdersImportRequest.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENTelcelDirection.InternalRecursiveSave();
ssENDivision.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_0ac0129639ce616349f284f107640b9e Duplicate() {
RC_0ac0129639ce616349f284f107640b9e t;
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrdersImportRequest = (EN_8c3668a93870461b8ea1216c2848f298EntityRecord)this.ssENOrdersImportRequest.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENTelcelDirection = (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord)this.ssENTelcelDirection.Duplicate();
t.ssENDivision = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENDivision.Duplicate();
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
if (head == "orderstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderStatus")) variable.Value = ssENOrderStatus; else variable.Optimized = true;
variable.SetFieldName("orderstatus");
} else if (head == "ordersimportrequest") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrdersImportRequest")) variable.Value = ssENOrdersImportRequest; else variable.Optimized = true;
variable.SetFieldName("ordersimportrequest");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssENTelcelDirection; else variable.Optimized = true;
variable.SetFieldName("telceldirection");
} else if (head == "division") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Division")) variable.Value = ssENDivision; else variable.Optimized = true;
variable.SetFieldName("division");
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
if (key == IdOrderStatus) {
return ssENOrderStatus;
}
if (key == IdOrdersImportRequest) {
return ssENOrdersImportRequest;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdTelcelDirection) {
return ssENTelcelDirection;
}
if (key == IdDivision) {
return ssENDivision;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssENOrderStatus;
}
if (attributeKey == IdOrdersImportRequest.Key.AsGuid) {
return ssENOrdersImportRequest;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssENTelcelDirection;
}
if (attributeKey == IdDivision.Key.AsGuid) {
return ssENDivision;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrdersImportRequest.FillFromOther((IRecord) other.AttributeGet(IdOrdersImportRequest));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdTelcelDirection));
ssENDivision.FillFromOther((IRecord) other.AttributeGet(IdDivision));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_0ac0129639ce616349f284f107640b9e
/// <summary>
/// RecordList type
///  <code>OrderStatusOrdersImportRequestOrderMainTelcelDirectionDivisionRegionRecordList</code> tha
/// t represents a record list of <code>OrderStatus, OrdersImportRequest, OrderMain, TelcelDirection,
///  Region, Region</code>
/// </summary>
public partial class RL_96ceba485e5175415cee03a11e0c33fb : GenericRecordList<RC_0ac0129639ce616349f284f107640b9e>, IEnumerable, IEnumerator {

protected override RC_0ac0129639ce616349f284f107640b9e GetElementDefaultValue() {
return new RC_0ac0129639ce616349f284f107640b9e();
}

public T[] ToArray<T>(Func<RC_0ac0129639ce616349f284f107640b9e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_96ceba485e5175415cee03a11e0c33fb recordList, Func<RC_0ac0129639ce616349f284f107640b9e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_96ceba485e5175415cee03a11e0c33fb(RC_0ac0129639ce616349f284f107640b9e[] array) {
  RL_96ceba485e5175415cee03a11e0c33fb result = new RL_96ceba485e5175415cee03a11e0c33fb();
result.InnerFromArray(array);
    return result;
}

public static RL_96ceba485e5175415cee03a11e0c33fb ToList<T>(T[] array, Func <T, RC_0ac0129639ce616349f284f107640b9e> converter) {
  RL_96ceba485e5175415cee03a11e0c33fb result = new RL_96ceba485e5175415cee03a11e0c33fb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_96ceba485e5175415cee03a11e0c33fb FromRestList<T>(RestList<T> restList, Func <T, RC_0ac0129639ce616349f284f107640b9e> converter) {
  RL_96ceba485e5175415cee03a11e0c33fb result = new RL_96ceba485e5175415cee03a11e0c33fb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_96ceba485e5175415cee03a11e0c33fb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(6,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(7,false);
def[4] = new BitArray(13,false);
def[5] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0ac0129639ce616349f284f107640b9e> NewList() {
return new RL_96ceba485e5175415cee03a11e0c33fb();
}


} // RL_96ceba485e5175415cee03a11e0c33fb
}

