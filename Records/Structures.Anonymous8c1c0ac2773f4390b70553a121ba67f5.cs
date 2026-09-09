namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (wgocjD93kEO3BVOhIbpn9Q)
///  <code>RC_06ae1f23d9c7cedfe36d2b236ac6d94c</code> that represent
/// s <code>CurrencyIdOrderMainIdCompanyIdDocumentTypeIdRegionIdRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyIdOrderMainIdCompanyIdDocumentTypeIdRegionIdRecord
public partial struct RC_06ae1f23d9c7cedfe36d2b236ac6d94c : ITypedRecord<RC_06ae1f23d9c7cedfe36d2b236ac6d94c> {
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*znYSnWfWfHRxgLsItiYd8A");
internal static readonly GlobalObjectKey IdOrderMainId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*VMdL9U7_4X6FxwfV55xiag");
internal static readonly GlobalObjectKey IdCompanyId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*RGWZ9R7OJtCAm7gtMRWM7A");
internal static readonly GlobalObjectKey IdDocumentTypeId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ossnGvfSYZVoEaeXuwr_MA");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nkxR7nUXmQLbRVrKGXTzig");

public string ssCurrencyId;

public long ssOrderMainId;

public long ssCompanyId;

public long ssDocumentTypeId;

public long ssRegionId;


public BitArray OptimizedAttributes;

public RC_06ae1f23d9c7cedfe36d2b236ac6d94c() {
OptimizedAttributes = null;
ssCurrencyId = "";
ssOrderMainId = 0L;
ssCompanyId = 0L;
ssDocumentTypeId = 0L;
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
ssCurrencyId = r.ReadEntityReferenceText(index++, "CurrencyIdOrderMainIdCompanyIdDocumentTypeIdRegionIdRecord.CurrencyId", "");
ssOrderMainId = r.ReadEntityReferenceLongInteger(index++, "CurrencyIdOrderMainIdCompanyIdDocumentTypeIdRegionIdRecord.OrderMainId", 0L);
ssCompanyId = r.ReadEntityReferenceLongInteger(index++, "CurrencyIdOrderMainIdCompanyIdDocumentTypeIdRegionIdRecord.CompanyId", 0L);
ssDocumentTypeId = r.ReadEntityReferenceLongInteger(index++, "CurrencyIdOrderMainIdCompanyIdDocumentTypeIdRegionIdRecord.DocumentTypeId", 0L);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "CurrencyIdOrderMainIdCompanyIdDocumentTypeIdRegionIdRecord.RegionId", 0L);
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
public void ReadIM(RC_06ae1f23d9c7cedfe36d2b236ac6d94c r) {
this = r;
}


public static bool operator == (RC_06ae1f23d9c7cedfe36d2b236ac6d94c a, RC_06ae1f23d9c7cedfe36d2b236ac6d94c b) {
if (a.ssCurrencyId != b.ssCurrencyId) return false;
if (a.ssOrderMainId != b.ssOrderMainId) return false;
if (a.ssCompanyId != b.ssCompanyId) return false;
if (a.ssDocumentTypeId != b.ssDocumentTypeId) return false;
if (a.ssRegionId != b.ssRegionId) return false;
return true;
}

public static bool operator != (RC_06ae1f23d9c7cedfe36d2b236ac6d94c a, RC_06ae1f23d9c7cedfe36d2b236ac6d94c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_06ae1f23d9c7cedfe36d2b236ac6d94c)) return false;
return (this == (RC_06ae1f23d9c7cedfe36d2b236ac6d94c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCurrencyId.GetHashCode()
 ^ ssOrderMainId.GetHashCode()
 ^ ssCompanyId.GetHashCode()
 ^ ssDocumentTypeId.GetHashCode()
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


public RC_06ae1f23d9c7cedfe36d2b236ac6d94c Duplicate() {
RC_06ae1f23d9c7cedfe36d2b236ac6d94c t;
t.ssCurrencyId = this.ssCurrencyId;
t.ssOrderMainId = this.ssOrderMainId;
t.ssCompanyId = this.ssCompanyId;
t.ssDocumentTypeId = this.ssDocumentTypeId;
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
} else if (head == "ordermainid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainId")) variable.Value = ssOrderMainId; else variable.Optimized = true;
} else if (head == "companyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompanyId")) variable.Value = ssCompanyId; else variable.Optimized = true;
} else if (head == "documenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentTypeId")) variable.Value = ssDocumentTypeId; else variable.Optimized = true;
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
if (key == IdOrderMainId) {
return ssOrderMainId;
}
if (key == IdCompanyId) {
return ssCompanyId;
}
if (key == IdDocumentTypeId) {
return ssDocumentTypeId;
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
if (attributeKey == IdOrderMainId.Key.AsGuid) {
return ssOrderMainId;
}
if (attributeKey == IdCompanyId.Key.AsGuid) {
return ssCompanyId;
}
if (attributeKey == IdDocumentTypeId.Key.AsGuid) {
return ssDocumentTypeId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCurrencyId = (string) other.AttributeGet(IdCurrencyId);
ssOrderMainId = (long) other.AttributeGet(IdOrderMainId);
ssCompanyId = (long) other.AttributeGet(IdCompanyId);
ssDocumentTypeId = (long) other.AttributeGet(IdDocumentTypeId);
ssRegionId = (long) other.AttributeGet(IdRegionId);
}
} // RC_06ae1f23d9c7cedfe36d2b236ac6d94c
/// <summary>
/// RecordList type <code>CurrencyIdOrderMainIdCompanyIdDocumentTypeIdRegionIdRecordList</code> that
///  represents a record list of <code>CurrencyIdentifier, OrderMainIdentifier, CompanyIdentifier
/// , DocumentTypeIdentifier, RegionIdentifier</code>
/// </summary>
public partial class RL_a717c2ee3d18817cb114d527dff3b8a0 : GenericRecordList<RC_06ae1f23d9c7cedfe36d2b236ac6d94c>, IEnumerable, IEnumerator {

protected override RC_06ae1f23d9c7cedfe36d2b236ac6d94c GetElementDefaultValue() {
return new RC_06ae1f23d9c7cedfe36d2b236ac6d94c();
}

public T[] ToArray<T>(Func<RC_06ae1f23d9c7cedfe36d2b236ac6d94c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a717c2ee3d18817cb114d527dff3b8a0 recordList, Func<RC_06ae1f23d9c7cedfe36d2b236ac6d94c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a717c2ee3d18817cb114d527dff3b8a0(RC_06ae1f23d9c7cedfe36d2b236ac6d94c[] array) {
  RL_a717c2ee3d18817cb114d527dff3b8a0 result = new RL_a717c2ee3d18817cb114d527dff3b8a0();
result.InnerFromArray(array);
    return result;
}

public static RL_a717c2ee3d18817cb114d527dff3b8a0 ToList<T>(T[] array, Func <T, RC_06ae1f23d9c7cedfe36d2b236ac6d94c> converter) {
  RL_a717c2ee3d18817cb114d527dff3b8a0 result = new RL_a717c2ee3d18817cb114d527dff3b8a0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a717c2ee3d18817cb114d527dff3b8a0 FromRestList<T>(RestList<T> restList, Func <T, RC_06ae1f23d9c7cedfe36d2b236ac6d94c> converter) {
  RL_a717c2ee3d18817cb114d527dff3b8a0 result = new RL_a717c2ee3d18817cb114d527dff3b8a0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a717c2ee3d18817cb114d527dff3b8a0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_06ae1f23d9c7cedfe36d2b236ac6d94c> NewList() {
return new RL_a717c2ee3d18817cb114d527dff3b8a0();
}


} // RL_a717c2ee3d18817cb114d527dff3b8a0
}

