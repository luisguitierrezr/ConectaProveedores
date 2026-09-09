namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Ge2nEzuvy0m3yon1O18fsw)
///  <code>RC_6238dc44386da10198e9e1b2b81cc9aa</code> that represent
/// s <code>CostCenterIdDivisionIdDocumentClassIdRegionIdServiceTypeIdCurrencyIdRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: CostCenterIdDivisionIdDocumentClassIdRegionIdServiceTypeIdCurrencyIdRecord
public partial struct RC_6238dc44386da10198e9e1b2b81cc9aa : ITypedRecord<RC_6238dc44386da10198e9e1b2b81cc9aa> {
internal static readonly GlobalObjectKey IdCostCenterId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SIR6IkgXkqGODXcQ2i9Tgg");
internal static readonly GlobalObjectKey IdDivisionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FWvmBpiDlw2GTBz9QXBeJA");
internal static readonly GlobalObjectKey IdDocumentClassId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AJxrdTpTHQ4YBIkvrGNELQ");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gcEzGObtOtm5olUL8jFgfA");
internal static readonly GlobalObjectKey IdServiceTypeId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+v_aOxXAnMi4vWiWDVqeIw");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sQWYxXVEbLb3BJDrPn4u2A");

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTCostCenterId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTDivisionId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTDocumentClassId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTRegionId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTServiceTypeId;

public ST_1f76dfa138680efe9e5e11deb3c828b8Structure ssSTCurrencyId;


public BitArray OptimizedAttributes;

public RC_6238dc44386da10198e9e1b2b81cc9aa() {
OptimizedAttributes = null;
ssSTCostCenterId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTDivisionId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTDocumentClassId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTRegionId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTServiceTypeId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTCurrencyId = new ST_1f76dfa138680efe9e5e11deb3c828b8Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    all[3] = null;
    all[4] = null;
    all[5] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTCostCenterId.OptimizedAttributes = value[0];
    ssSTDivisionId.OptimizedAttributes = value[1];
    ssSTDocumentClassId.OptimizedAttributes = value[2];
    ssSTRegionId.OptimizedAttributes = value[3];
    ssSTServiceTypeId.OptimizedAttributes = value[4];
    ssSTCurrencyId.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    all[3] = null;
    all[4] = null;
    all[5] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTCostCenterId.Read( r, ref index);
ssSTDivisionId.Read( r, ref index);
ssSTDocumentClassId.Read( r, ref index);
ssSTRegionId.Read( r, ref index);
ssSTServiceTypeId.Read( r, ref index);
ssSTCurrencyId.Read( r, ref index);
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
public void ReadIM(RC_6238dc44386da10198e9e1b2b81cc9aa r) {
this = r;
}


public static bool operator == (RC_6238dc44386da10198e9e1b2b81cc9aa a, RC_6238dc44386da10198e9e1b2b81cc9aa b) {
if (a.ssSTCostCenterId != b.ssSTCostCenterId) return false;
if (a.ssSTDivisionId != b.ssSTDivisionId) return false;
if (a.ssSTDocumentClassId != b.ssSTDocumentClassId) return false;
if (a.ssSTRegionId != b.ssSTRegionId) return false;
if (a.ssSTServiceTypeId != b.ssSTServiceTypeId) return false;
if (a.ssSTCurrencyId != b.ssSTCurrencyId) return false;
return true;
}

public static bool operator != (RC_6238dc44386da10198e9e1b2b81cc9aa a, RC_6238dc44386da10198e9e1b2b81cc9aa b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6238dc44386da10198e9e1b2b81cc9aa)) return false;
return (this == (RC_6238dc44386da10198e9e1b2b81cc9aa)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCostCenterId.GetHashCode()
 ^ ssSTDivisionId.GetHashCode()
 ^ ssSTDocumentClassId.GetHashCode()
 ^ ssSTRegionId.GetHashCode()
 ^ ssSTServiceTypeId.GetHashCode()
 ^ ssSTCurrencyId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCostCenterId.RecursiveReset();
ssSTDivisionId.RecursiveReset();
ssSTDocumentClassId.RecursiveReset();
ssSTRegionId.RecursiveReset();
ssSTServiceTypeId.RecursiveReset();
ssSTCurrencyId.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCostCenterId.InternalRecursiveSave();
ssSTDivisionId.InternalRecursiveSave();
ssSTDocumentClassId.InternalRecursiveSave();
ssSTRegionId.InternalRecursiveSave();
ssSTServiceTypeId.InternalRecursiveSave();
ssSTCurrencyId.InternalRecursiveSave();
}


public RC_6238dc44386da10198e9e1b2b81cc9aa Duplicate() {
RC_6238dc44386da10198e9e1b2b81cc9aa t;
t.ssSTCostCenterId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTCostCenterId.Duplicate();
t.ssSTDivisionId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTDivisionId.Duplicate();
t.ssSTDocumentClassId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTDocumentClassId.Duplicate();
t.ssSTRegionId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTRegionId.Duplicate();
t.ssSTServiceTypeId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTServiceTypeId.Duplicate();
t.ssSTCurrencyId = (ST_1f76dfa138680efe9e5e11deb3c828b8Structure)this.ssSTCurrencyId.Duplicate();
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
if (head == "costcenterid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterId")) variable.Value = ssSTCostCenterId; else variable.Optimized = true;
variable.SetFieldName("costcenterid");
} else if (head == "divisionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DivisionId")) variable.Value = ssSTDivisionId; else variable.Optimized = true;
variable.SetFieldName("divisionid");
} else if (head == "documentclassid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentClassId")) variable.Value = ssSTDocumentClassId; else variable.Optimized = true;
variable.SetFieldName("documentclassid");
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssSTRegionId; else variable.Optimized = true;
variable.SetFieldName("regionid");
} else if (head == "servicetypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ServiceTypeId")) variable.Value = ssSTServiceTypeId; else variable.Optimized = true;
variable.SetFieldName("servicetypeid");
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssSTCurrencyId; else variable.Optimized = true;
variable.SetFieldName("currencyid");
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
if (key == IdCostCenterId) {
return ssSTCostCenterId;
}
if (key == IdDivisionId) {
return ssSTDivisionId;
}
if (key == IdDocumentClassId) {
return ssSTDocumentClassId;
}
if (key == IdRegionId) {
return ssSTRegionId;
}
if (key == IdServiceTypeId) {
return ssSTServiceTypeId;
}
if (key == IdCurrencyId) {
return ssSTCurrencyId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCostCenterId.Key.AsGuid) {
return ssSTCostCenterId;
}
if (attributeKey == IdDivisionId.Key.AsGuid) {
return ssSTDivisionId;
}
if (attributeKey == IdDocumentClassId.Key.AsGuid) {
return ssSTDocumentClassId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssSTRegionId;
}
if (attributeKey == IdServiceTypeId.Key.AsGuid) {
return ssSTServiceTypeId;
}
if (attributeKey == IdCurrencyId.Key.AsGuid) {
return ssSTCurrencyId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCostCenterId.FillFromOther((IRecord) other.AttributeGet(IdCostCenterId));
ssSTDivisionId.FillFromOther((IRecord) other.AttributeGet(IdDivisionId));
ssSTDocumentClassId.FillFromOther((IRecord) other.AttributeGet(IdDocumentClassId));
ssSTRegionId.FillFromOther((IRecord) other.AttributeGet(IdRegionId));
ssSTServiceTypeId.FillFromOther((IRecord) other.AttributeGet(IdServiceTypeId));
ssSTCurrencyId.FillFromOther((IRecord) other.AttributeGet(IdCurrencyId));
}
} // RC_6238dc44386da10198e9e1b2b81cc9aa
/// <summary>
/// RecordList type
///  <code>CostCenterIdDivisionIdDocumentClassIdRegionIdServiceTypeIdCurrencyIdRecordList</code> tha
/// t represents a record list of <code>LongIntegerIdentifier, LongIntegerIdentifier,
///  LongIntegerIdentifier, LongIntegerIdentifier, LongIntegerIdentifier, Text</code>
/// </summary>
public partial class RL_0a57e83422b4463daf632e7f94ace47e : GenericRecordList<RC_6238dc44386da10198e9e1b2b81cc9aa>, IEnumerable, IEnumerator {

protected override RC_6238dc44386da10198e9e1b2b81cc9aa GetElementDefaultValue() {
return new RC_6238dc44386da10198e9e1b2b81cc9aa();
}

public T[] ToArray<T>(Func<RC_6238dc44386da10198e9e1b2b81cc9aa, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0a57e83422b4463daf632e7f94ace47e recordList, Func<RC_6238dc44386da10198e9e1b2b81cc9aa, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0a57e83422b4463daf632e7f94ace47e(RC_6238dc44386da10198e9e1b2b81cc9aa[] array) {
  RL_0a57e83422b4463daf632e7f94ace47e result = new RL_0a57e83422b4463daf632e7f94ace47e();
result.InnerFromArray(array);
    return result;
}

public static RL_0a57e83422b4463daf632e7f94ace47e ToList<T>(T[] array, Func <T, RC_6238dc44386da10198e9e1b2b81cc9aa> converter) {
  RL_0a57e83422b4463daf632e7f94ace47e result = new RL_0a57e83422b4463daf632e7f94ace47e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0a57e83422b4463daf632e7f94ace47e FromRestList<T>(RestList<T> restList, Func <T, RC_6238dc44386da10198e9e1b2b81cc9aa> converter) {
  RL_0a57e83422b4463daf632e7f94ace47e result = new RL_0a57e83422b4463daf632e7f94ace47e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0a57e83422b4463daf632e7f94ace47e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = null;
def[1] = null;
def[2] = null;
def[3] = null;
def[4] = null;
def[5] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6238dc44386da10198e9e1b2b81cc9aa> NewList() {
return new RL_0a57e83422b4463daf632e7f94ace47e();
}


} // RL_0a57e83422b4463daf632e7f94ace47e
}

