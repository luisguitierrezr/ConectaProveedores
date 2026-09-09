namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6r8MaW3_vESoNeq8r27wBg)
///  <code>RC_98e72683eb82d34cf7fcf42a642043ce</code> that represent
/// s <code>CurrencyIdCostCenterSAPIdDivisionIdDocumentClassIdGLAccountIdRegionIdRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: CurrencyIdCostCenterSAPIdDivisionIdDocumentClassIdGLAccountIdRegionIdRecord
public partial struct RC_98e72683eb82d34cf7fcf42a642043ce : ITypedRecord<RC_98e72683eb82d34cf7fcf42a642043ce> {
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*znYSnWfWfHRxgLsItiYd8A");
internal static readonly GlobalObjectKey IdCostCenterSAPId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3tt9DdzuVcrVdYr1iDqing");
internal static readonly GlobalObjectKey IdDivisionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NmwsZljUhsJ_kXsuV94cxw");
internal static readonly GlobalObjectKey IdDocumentClassId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*4XP2Rd8BbI7_nFVIu_v+Eg");
internal static readonly GlobalObjectKey IdGLAccountId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*cQoZ9oKyeroxEcj+j93qvg");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nkxR7nUXmQLbRVrKGXTzig");

public string ssCurrencyId;

public long ssCostCenterSAPId;

public long ssDivisionId;

public long ssDocumentClassId;

public long ssGLAccountId;

public long ssRegionId;


public BitArray OptimizedAttributes;

public RC_98e72683eb82d34cf7fcf42a642043ce() {
OptimizedAttributes = null;
ssCurrencyId = "";
ssCostCenterSAPId = 0L;
ssDivisionId = 0L;
ssDocumentClassId = 0L;
ssGLAccountId = 0L;
ssRegionId = 0L;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssCurrencyId = r.ReadEntityReferenceText(index++, "CurrencyIdCostCenterSAPIdDivisionIdDocumentClassIdGLAccountIdRegionIdRecord.CurrencyId", "");
ssCostCenterSAPId = r.ReadEntityReferenceLongInteger(index++, "CurrencyIdCostCenterSAPIdDivisionIdDocumentClassIdGLAccountIdRegionIdRecord.CostCenterSAPId", 0L);
ssDivisionId = r.ReadEntityReferenceLongInteger(index++, "CurrencyIdCostCenterSAPIdDivisionIdDocumentClassIdGLAccountIdRegionIdRecord.DivisionId", 0L);
ssDocumentClassId = r.ReadEntityReferenceLongInteger(index++, "CurrencyIdCostCenterSAPIdDivisionIdDocumentClassIdGLAccountIdRegionIdRecord.DocumentClassId", 0L);
ssGLAccountId = r.ReadEntityReferenceLongInteger(index++, "CurrencyIdCostCenterSAPIdDivisionIdDocumentClassIdGLAccountIdRegionIdRecord.GLAccountId", 0L);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "CurrencyIdCostCenterSAPIdDivisionIdDocumentClassIdGLAccountIdRegionIdRecord.RegionId", 0L);
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
public void ReadIM(RC_98e72683eb82d34cf7fcf42a642043ce r) {
this = r;
}


public static bool operator == (RC_98e72683eb82d34cf7fcf42a642043ce a, RC_98e72683eb82d34cf7fcf42a642043ce b) {
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssCostCenterSAPId != b.ssCostCenterSAPId) return false;
if (a.ssDivisionId != b.ssDivisionId) return false;
if (a.ssDocumentClassId != b.ssDocumentClassId) return false;
if (a.ssGLAccountId != b.ssGLAccountId) return false;
if (a.ssRegionId != b.ssRegionId) return false;
return true;
}

public static bool operator != (RC_98e72683eb82d34cf7fcf42a642043ce a, RC_98e72683eb82d34cf7fcf42a642043ce b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_98e72683eb82d34cf7fcf42a642043ce)) return false;
return (this == (RC_98e72683eb82d34cf7fcf42a642043ce)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssCostCenterSAPId.GetHashCode()
 ^ ssDivisionId.GetHashCode()
 ^ ssDocumentClassId.GetHashCode()
 ^ ssGLAccountId.GetHashCode()
 ^ ssRegionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_98e72683eb82d34cf7fcf42a642043ce Duplicate() {
RC_98e72683eb82d34cf7fcf42a642043ce t;
t.ssCurrencyId = this.ssCurrencyId;
t.ssCostCenterSAPId = this.ssCostCenterSAPId;
t.ssDivisionId = this.ssDivisionId;
t.ssDocumentClassId = this.ssDocumentClassId;
t.ssGLAccountId = this.ssGLAccountId;
t.ssRegionId = this.ssRegionId;
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
if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssCurrencyId; else variable.Optimized = true;
} else if (head == "costcentersapid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterSAPId")) variable.Value = ssCostCenterSAPId; else variable.Optimized = true;
} else if (head == "divisionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DivisionId")) variable.Value = ssDivisionId; else variable.Optimized = true;
} else if (head == "documentclassid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentClassId")) variable.Value = ssDocumentClassId; else variable.Optimized = true;
} else if (head == "glaccountid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GLAccountId")) variable.Value = ssGLAccountId; else variable.Optimized = true;
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
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
if (key == IdCurrencyId) {
return ssCurrencyId;
}
if (key == IdCostCenterSAPId) {
return ssCostCenterSAPId;
}
if (key == IdDivisionId) {
return ssDivisionId;
}
if (key == IdDocumentClassId) {
return ssDocumentClassId;
}
if (key == IdGLAccountId) {
return ssGLAccountId;
}
if (key == IdRegionId) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrencyId.Key.AsGuid) {
return ssCurrencyId;
}
if (attributeKey == IdCostCenterSAPId.Key.AsGuid) {
return ssCostCenterSAPId;
}
if (attributeKey == IdDivisionId.Key.AsGuid) {
return ssDivisionId;
}
if (attributeKey == IdDocumentClassId.Key.AsGuid) {
return ssDocumentClassId;
}
if (attributeKey == IdGLAccountId.Key.AsGuid) {
return ssGLAccountId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCurrencyId = (string) other.AttributeGet(IdCurrencyId);
ssCostCenterSAPId = (long) other.AttributeGet(IdCostCenterSAPId);
ssDivisionId = (long) other.AttributeGet(IdDivisionId);
ssDocumentClassId = (long) other.AttributeGet(IdDocumentClassId);
ssGLAccountId = (long) other.AttributeGet(IdGLAccountId);
ssRegionId = (long) other.AttributeGet(IdRegionId);
}
} // RC_98e72683eb82d34cf7fcf42a642043ce
/// <summary>
/// RecordList type
///  <code>CurrencyIdCostCenterSAPIdDivisionIdDocumentClassIdGLAccountIdRegionIdRecordList</code> tha
/// t represents a record list of <code>CurrencyIdentifier, CostCenterSAPIdentifier, RegionIdentifier,
///  DocumentTypeIdentifier, AccountingAccounts_ServiceTypeIdentifier, RegionIdentifier</code>
/// </summary>
public partial class RL_553c22da66397b3847ae0a72912de863 : GenericRecordList<RC_98e72683eb82d34cf7fcf42a642043ce>, IEnumerable, IEnumerator {

protected override RC_98e72683eb82d34cf7fcf42a642043ce GetElementDefaultValue() {
return new RC_98e72683eb82d34cf7fcf42a642043ce();
}

public T[] ToArray<T>(Func<RC_98e72683eb82d34cf7fcf42a642043ce, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_553c22da66397b3847ae0a72912de863 recordList, Func<RC_98e72683eb82d34cf7fcf42a642043ce, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_553c22da66397b3847ae0a72912de863(RC_98e72683eb82d34cf7fcf42a642043ce[] array) {
  RL_553c22da66397b3847ae0a72912de863 result = new RL_553c22da66397b3847ae0a72912de863();
result.InnerFromArray(array);
    return result;
}

public static RL_553c22da66397b3847ae0a72912de863 ToList<T>(T[] array, Func <T, RC_98e72683eb82d34cf7fcf42a642043ce> converter) {
  RL_553c22da66397b3847ae0a72912de863 result = new RL_553c22da66397b3847ae0a72912de863();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_553c22da66397b3847ae0a72912de863 FromRestList<T>(RestList<T> restList, Func <T, RC_98e72683eb82d34cf7fcf42a642043ce> converter) {
  RL_553c22da66397b3847ae0a72912de863 result = new RL_553c22da66397b3847ae0a72912de863();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_553c22da66397b3847ae0a72912de863() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_98e72683eb82d34cf7fcf42a642043ce> NewList() {
return new RL_553c22da66397b3847ae0a72912de863();
}


} // RL_553c22da66397b3847ae0a72912de863
}

