namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (yMQJlirAVkGUclojrhMUuw)
///  <code>RC_b8337e876917ffb03ca766882c5f94fb</code> that represent
/// s
///  <code>CostCenterIdDirectionIdDivisionIdDocumentClassIdInvoiceUsageIdRegionIdServiceTypeIdRecord</co
/// de> <p>Description: </p>
/// </summary>
// Name: CostCenterIdDirectionIdDivisionIdDocumentClassIdInvoiceUsageIdRegionIdServiceTypeIdRecord
public partial struct RC_b8337e876917ffb03ca766882c5f94fb : ITypedRecord<RC_b8337e876917ffb03ca766882c5f94fb> {
internal static readonly GlobalObjectKey IdCostCenterId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SIR6IkgXkqGODXcQ2i9Tgg");
internal static readonly GlobalObjectKey IdDirectionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*8ziLA7l3O9jC1mSHPhc9MQ");
internal static readonly GlobalObjectKey IdDivisionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FWvmBpiDlw2GTBz9QXBeJA");
internal static readonly GlobalObjectKey IdDocumentClassId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*AJxrdTpTHQ4YBIkvrGNELQ");
internal static readonly GlobalObjectKey IdInvoiceUsageId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*V9C5Bh6QjP6aVDVDPT+2jQ");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gcEzGObtOtm5olUL8jFgfA");
internal static readonly GlobalObjectKey IdServiceTypeId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+v_aOxXAnMi4vWiWDVqeIw");

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTCostCenterId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTDirectionId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTDivisionId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTDocumentClassId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTInvoiceUsageId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTRegionId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTServiceTypeId;


public BitArray OptimizedAttributes;

public RC_b8337e876917ffb03ca766882c5f94fb() {
OptimizedAttributes = null;
ssSTCostCenterId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTDirectionId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTDivisionId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTDocumentClassId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTInvoiceUsageId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTRegionId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTServiceTypeId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    all[3] = null;
    all[4] = null;
    all[5] = null;
    all[6] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTCostCenterId.OptimizedAttributes = value[0];
    ssSTDirectionId.OptimizedAttributes = value[1];
    ssSTDivisionId.OptimizedAttributes = value[2];
    ssSTDocumentClassId.OptimizedAttributes = value[3];
    ssSTInvoiceUsageId.OptimizedAttributes = value[4];
    ssSTRegionId.OptimizedAttributes = value[5];
    ssSTServiceTypeId.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    all[3] = null;
    all[4] = null;
    all[5] = null;
    all[6] = null;
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
ssSTDirectionId.Read( r, ref index);
ssSTDivisionId.Read( r, ref index);
ssSTDocumentClassId.Read( r, ref index);
ssSTInvoiceUsageId.Read( r, ref index);
ssSTRegionId.Read( r, ref index);
ssSTServiceTypeId.Read( r, ref index);
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
public void ReadIM(RC_b8337e876917ffb03ca766882c5f94fb r) {
this = r;
}


public static bool operator == (RC_b8337e876917ffb03ca766882c5f94fb a, RC_b8337e876917ffb03ca766882c5f94fb b) {
if (a.ssSTCostCenterId != b.ssSTCostCenterId) return false;
if (a.ssSTDirectionId != b.ssSTDirectionId) return false;
if (a.ssSTDivisionId != b.ssSTDivisionId) return false;
if (a.ssSTDocumentClassId != b.ssSTDocumentClassId) return false;
if (a.ssSTInvoiceUsageId != b.ssSTInvoiceUsageId) return false;
if (a.ssSTRegionId != b.ssSTRegionId) return false;
if (a.ssSTServiceTypeId != b.ssSTServiceTypeId) return false;
return true;
}

public static bool operator != (RC_b8337e876917ffb03ca766882c5f94fb a, RC_b8337e876917ffb03ca766882c5f94fb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b8337e876917ffb03ca766882c5f94fb)) return false;
return (this == (RC_b8337e876917ffb03ca766882c5f94fb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCostCenterId.GetHashCode()
 ^ ssSTDirectionId.GetHashCode()
 ^ ssSTDivisionId.GetHashCode()
 ^ ssSTDocumentClassId.GetHashCode()
 ^ ssSTInvoiceUsageId.GetHashCode()
 ^ ssSTRegionId.GetHashCode()
 ^ ssSTServiceTypeId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCostCenterId.RecursiveReset();
ssSTDirectionId.RecursiveReset();
ssSTDivisionId.RecursiveReset();
ssSTDocumentClassId.RecursiveReset();
ssSTInvoiceUsageId.RecursiveReset();
ssSTRegionId.RecursiveReset();
ssSTServiceTypeId.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCostCenterId.InternalRecursiveSave();
ssSTDirectionId.InternalRecursiveSave();
ssSTDivisionId.InternalRecursiveSave();
ssSTDocumentClassId.InternalRecursiveSave();
ssSTInvoiceUsageId.InternalRecursiveSave();
ssSTRegionId.InternalRecursiveSave();
ssSTServiceTypeId.InternalRecursiveSave();
}


public RC_b8337e876917ffb03ca766882c5f94fb Duplicate() {
RC_b8337e876917ffb03ca766882c5f94fb t;
t.ssSTCostCenterId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTCostCenterId.Duplicate();
t.ssSTDirectionId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTDirectionId.Duplicate();
t.ssSTDivisionId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTDivisionId.Duplicate();
t.ssSTDocumentClassId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTDocumentClassId.Duplicate();
t.ssSTInvoiceUsageId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTInvoiceUsageId.Duplicate();
t.ssSTRegionId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTRegionId.Duplicate();
t.ssSTServiceTypeId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTServiceTypeId.Duplicate();
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
} else if (head == "directionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DirectionId")) variable.Value = ssSTDirectionId; else variable.Optimized = true;
variable.SetFieldName("directionid");
} else if (head == "divisionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DivisionId")) variable.Value = ssSTDivisionId; else variable.Optimized = true;
variable.SetFieldName("divisionid");
} else if (head == "documentclassid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentClassId")) variable.Value = ssSTDocumentClassId; else variable.Optimized = true;
variable.SetFieldName("documentclassid");
} else if (head == "invoiceusageid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUsageId")) variable.Value = ssSTInvoiceUsageId; else variable.Optimized = true;
variable.SetFieldName("invoiceusageid");
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssSTRegionId; else variable.Optimized = true;
variable.SetFieldName("regionid");
} else if (head == "servicetypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ServiceTypeId")) variable.Value = ssSTServiceTypeId; else variable.Optimized = true;
variable.SetFieldName("servicetypeid");
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
if (key == IdDirectionId) {
return ssSTDirectionId;
}
if (key == IdDivisionId) {
return ssSTDivisionId;
}
if (key == IdDocumentClassId) {
return ssSTDocumentClassId;
}
if (key == IdInvoiceUsageId) {
return ssSTInvoiceUsageId;
}
if (key == IdRegionId) {
return ssSTRegionId;
}
if (key == IdServiceTypeId) {
return ssSTServiceTypeId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCostCenterId.Key.AsGuid) {
return ssSTCostCenterId;
}
if (attributeKey == IdDirectionId.Key.AsGuid) {
return ssSTDirectionId;
}
if (attributeKey == IdDivisionId.Key.AsGuid) {
return ssSTDivisionId;
}
if (attributeKey == IdDocumentClassId.Key.AsGuid) {
return ssSTDocumentClassId;
}
if (attributeKey == IdInvoiceUsageId.Key.AsGuid) {
return ssSTInvoiceUsageId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssSTRegionId;
}
if (attributeKey == IdServiceTypeId.Key.AsGuid) {
return ssSTServiceTypeId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCostCenterId.FillFromOther((IRecord) other.AttributeGet(IdCostCenterId));
ssSTDirectionId.FillFromOther((IRecord) other.AttributeGet(IdDirectionId));
ssSTDivisionId.FillFromOther((IRecord) other.AttributeGet(IdDivisionId));
ssSTDocumentClassId.FillFromOther((IRecord) other.AttributeGet(IdDocumentClassId));
ssSTInvoiceUsageId.FillFromOther((IRecord) other.AttributeGet(IdInvoiceUsageId));
ssSTRegionId.FillFromOther((IRecord) other.AttributeGet(IdRegionId));
ssSTServiceTypeId.FillFromOther((IRecord) other.AttributeGet(IdServiceTypeId));
}
} // RC_b8337e876917ffb03ca766882c5f94fb
/// <summary>
/// RecordList type
///  <code>CostCenterIdDirectionIdDivisionIdDocumentClassIdInvoiceUsageIdRegionIdServiceTypeIdRecordList
/// </code> that represents a record list of <code>LongIntegerIdentifier, LongIntegerIdentifier,
///  LongIntegerIdentifier, LongIntegerIdentifier, LongIntegerIdentifier, LongIntegerIdentifier
/// , LongIntegerIdentifier</code>
/// </summary>
public partial class RL_1fd700228cc5fdbb5577ed3fdc4f16ac : GenericRecordList<RC_b8337e876917ffb03ca766882c5f94fb>, IEnumerable, IEnumerator {

protected override RC_b8337e876917ffb03ca766882c5f94fb GetElementDefaultValue() {
return new RC_b8337e876917ffb03ca766882c5f94fb();
}

public T[] ToArray<T>(Func<RC_b8337e876917ffb03ca766882c5f94fb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1fd700228cc5fdbb5577ed3fdc4f16ac recordList, Func<RC_b8337e876917ffb03ca766882c5f94fb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1fd700228cc5fdbb5577ed3fdc4f16ac(RC_b8337e876917ffb03ca766882c5f94fb[] array) {
  RL_1fd700228cc5fdbb5577ed3fdc4f16ac result = new RL_1fd700228cc5fdbb5577ed3fdc4f16ac();
result.InnerFromArray(array);
    return result;
}

public static RL_1fd700228cc5fdbb5577ed3fdc4f16ac ToList<T>(T[] array, Func <T, RC_b8337e876917ffb03ca766882c5f94fb> converter) {
  RL_1fd700228cc5fdbb5577ed3fdc4f16ac result = new RL_1fd700228cc5fdbb5577ed3fdc4f16ac();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1fd700228cc5fdbb5577ed3fdc4f16ac FromRestList<T>(RestList<T> restList, Func <T, RC_b8337e876917ffb03ca766882c5f94fb> converter) {
  RL_1fd700228cc5fdbb5577ed3fdc4f16ac result = new RL_1fd700228cc5fdbb5577ed3fdc4f16ac();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1fd700228cc5fdbb5577ed3fdc4f16ac() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = null;
def[1] = null;
def[2] = null;
def[3] = null;
def[4] = null;
def[5] = null;
def[6] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b8337e876917ffb03ca766882c5f94fb> NewList() {
return new RL_1fd700228cc5fdbb5577ed3fdc4f16ac();
}


} // RL_1fd700228cc5fdbb5577ed3fdc4f16ac
}

