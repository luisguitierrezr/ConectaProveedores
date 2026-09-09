namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (pgzoixLoP0Cv6xxb2z0GWg)
///  <code>RC_f8d32413a09252891cf320a9f349aadb</code> that represent
/// s
///  <code>CompanyIdCompanyId_cDocumentTypeIdDocumentTypeId_cOrderMainIdOrderMainId_cRegionIdRegionId_cC
/// urrencyIdCurrencyId_cRecord</code> <p>Description: </p>
/// </summary>
// Name: CompanyIdCompanyId_cDocumentTypeIdDocumentTypeId_cOrderMainIdOrderMainId_cRegionIdRegionId_cCurrencyIdCurrencyId_cRecord
public partial struct RC_f8d32413a09252891cf320a9f349aadb : ITypedRecord<RC_f8d32413a09252891cf320a9f349aadb> {
internal static readonly GlobalObjectKey IdCompanyId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yVxTYk1gZtvVQfiJedHZbQ");
internal static readonly GlobalObjectKey IdCompanyId_c = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L9yto21axCInQGVTMNMfCA");
internal static readonly GlobalObjectKey IdDocumentTypeId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OZ2YhwrkjwaWI2zdS_iDxg");
internal static readonly GlobalObjectKey IdDocumentTypeId_c = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oGqPjV5CRMITBsC9IrM5cQ");
internal static readonly GlobalObjectKey IdOrderMainId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*XJ80WBaq7Y4RlijDG1ZTPg");
internal static readonly GlobalObjectKey IdOrderMainId_c = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*n3do+bQgT7jJQUFIAapGFg");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gcEzGObtOtm5olUL8jFgfA");
internal static readonly GlobalObjectKey IdRegionId_c = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tGbBJBrmzscNkby0akbKDw");
internal static readonly GlobalObjectKey IdCurrencyId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sQWYxXVEbLb3BJDrPn4u2A");
internal static readonly GlobalObjectKey IdCurrencyId_c = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k0xbXzaICgyKJ6g0Yfp2tg");

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTCompanyId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTCompanyId_c;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTDocumentTypeId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTDocumentTypeId_c;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTOrderMainId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTOrderMainId_c;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTRegionId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTRegionId_c;

public ST_1f76dfa138680efe9e5e11deb3c828b8Structure ssSTCurrencyId;

public ST_1f76dfa138680efe9e5e11deb3c828b8Structure ssSTCurrencyId_c;


public BitArray OptimizedAttributes;

public RC_f8d32413a09252891cf320a9f349aadb() {
OptimizedAttributes = null;
ssSTCompanyId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTCompanyId_c = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTDocumentTypeId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTDocumentTypeId_c = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTOrderMainId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTOrderMainId_c = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTRegionId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTRegionId_c = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTCurrencyId = new ST_1f76dfa138680efe9e5e11deb3c828b8Structure();
ssSTCurrencyId_c = new ST_1f76dfa138680efe9e5e11deb3c828b8Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[10];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    all[3] = null;
    all[4] = null;
    all[5] = null;
    all[6] = null;
    all[7] = null;
    all[8] = null;
    all[9] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTCompanyId.OptimizedAttributes = value[0];
    ssSTCompanyId_c.OptimizedAttributes = value[1];
    ssSTDocumentTypeId.OptimizedAttributes = value[2];
    ssSTDocumentTypeId_c.OptimizedAttributes = value[3];
    ssSTOrderMainId.OptimizedAttributes = value[4];
    ssSTOrderMainId_c.OptimizedAttributes = value[5];
    ssSTRegionId.OptimizedAttributes = value[6];
    ssSTRegionId_c.OptimizedAttributes = value[7];
    ssSTCurrencyId.OptimizedAttributes = value[8];
    ssSTCurrencyId_c.OptimizedAttributes = value[9];
    }
}
get{
    BitArray[] all = new BitArray[10];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    all[3] = null;
    all[4] = null;
    all[5] = null;
    all[6] = null;
    all[7] = null;
    all[8] = null;
    all[9] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTCompanyId.Read( r, ref index);
ssSTCompanyId_c.Read( r, ref index);
ssSTDocumentTypeId.Read( r, ref index);
ssSTDocumentTypeId_c.Read( r, ref index);
ssSTOrderMainId.Read( r, ref index);
ssSTOrderMainId_c.Read( r, ref index);
ssSTRegionId.Read( r, ref index);
ssSTRegionId_c.Read( r, ref index);
ssSTCurrencyId.Read( r, ref index);
ssSTCurrencyId_c.Read( r, ref index);
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
public void ReadIM(RC_f8d32413a09252891cf320a9f349aadb r) {
this = r;
}


public static bool operator == (RC_f8d32413a09252891cf320a9f349aadb a, RC_f8d32413a09252891cf320a9f349aadb b) {
if (a.ssSTCompanyId != b.ssSTCompanyId) return false;
if (a.ssSTCompanyId_c != b.ssSTCompanyId_c) return false;
if (a.ssSTDocumentTypeId != b.ssSTDocumentTypeId) return false;
if (a.ssSTDocumentTypeId_c != b.ssSTDocumentTypeId_c) return false;
if (a.ssSTOrderMainId != b.ssSTOrderMainId) return false;
if (a.ssSTOrderMainId_c != b.ssSTOrderMainId_c) return false;
if (a.ssSTRegionId != b.ssSTRegionId) return false;
if (a.ssSTRegionId_c != b.ssSTRegionId_c) return false;
if (a.ssSTCurrencyId != b.ssSTCurrencyId) return false;
if (a.ssSTCurrencyId_c != b.ssSTCurrencyId_c) return false;
return true;
}

public static bool operator != (RC_f8d32413a09252891cf320a9f349aadb a, RC_f8d32413a09252891cf320a9f349aadb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f8d32413a09252891cf320a9f349aadb)) return false;
return (this == (RC_f8d32413a09252891cf320a9f349aadb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCompanyId.GetHashCode()
 ^ ssSTCompanyId_c.GetHashCode()
 ^ ssSTDocumentTypeId.GetHashCode()
 ^ ssSTDocumentTypeId_c.GetHashCode()
 ^ ssSTOrderMainId.GetHashCode()
 ^ ssSTOrderMainId_c.GetHashCode()
 ^ ssSTRegionId.GetHashCode()
 ^ ssSTRegionId_c.GetHashCode()
 ^ ssSTCurrencyId.GetHashCode()
 ^ ssSTCurrencyId_c.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCompanyId.RecursiveReset();
ssSTCompanyId_c.RecursiveReset();
ssSTDocumentTypeId.RecursiveReset();
ssSTDocumentTypeId_c.RecursiveReset();
ssSTOrderMainId.RecursiveReset();
ssSTOrderMainId_c.RecursiveReset();
ssSTRegionId.RecursiveReset();
ssSTRegionId_c.RecursiveReset();
ssSTCurrencyId.RecursiveReset();
ssSTCurrencyId_c.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCompanyId.InternalRecursiveSave();
ssSTCompanyId_c.InternalRecursiveSave();
ssSTDocumentTypeId.InternalRecursiveSave();
ssSTDocumentTypeId_c.InternalRecursiveSave();
ssSTOrderMainId.InternalRecursiveSave();
ssSTOrderMainId_c.InternalRecursiveSave();
ssSTRegionId.InternalRecursiveSave();
ssSTRegionId_c.InternalRecursiveSave();
ssSTCurrencyId.InternalRecursiveSave();
ssSTCurrencyId_c.InternalRecursiveSave();
}


public RC_f8d32413a09252891cf320a9f349aadb Duplicate() {
RC_f8d32413a09252891cf320a9f349aadb t;
t.ssSTCompanyId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTCompanyId.Duplicate();
t.ssSTCompanyId_c = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTCompanyId_c.Duplicate();
t.ssSTDocumentTypeId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTDocumentTypeId.Duplicate();
t.ssSTDocumentTypeId_c = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTDocumentTypeId_c.Duplicate();
t.ssSTOrderMainId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTOrderMainId.Duplicate();
t.ssSTOrderMainId_c = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTOrderMainId_c.Duplicate();
t.ssSTRegionId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTRegionId.Duplicate();
t.ssSTRegionId_c = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTRegionId_c.Duplicate();
t.ssSTCurrencyId = (ST_1f76dfa138680efe9e5e11deb3c828b8Structure)this.ssSTCurrencyId.Duplicate();
t.ssSTCurrencyId_c = (ST_1f76dfa138680efe9e5e11deb3c828b8Structure)this.ssSTCurrencyId_c.Duplicate();
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
if (head == "companyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompanyId")) variable.Value = ssSTCompanyId; else variable.Optimized = true;
variable.SetFieldName("companyid");
} else if (head == "companyid_c") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CompanyId_c")) variable.Value = ssSTCompanyId_c; else variable.Optimized = true;
variable.SetFieldName("companyid_c");
} else if (head == "documenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentTypeId")) variable.Value = ssSTDocumentTypeId; else variable.Optimized = true;
variable.SetFieldName("documenttypeid");
} else if (head == "documenttypeid_c") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentTypeId_c")) variable.Value = ssSTDocumentTypeId_c; else variable.Optimized = true;
variable.SetFieldName("documenttypeid_c");
} else if (head == "ordermainid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainId")) variable.Value = ssSTOrderMainId; else variable.Optimized = true;
variable.SetFieldName("ordermainid");
} else if (head == "ordermainid_c") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainId_c")) variable.Value = ssSTOrderMainId_c; else variable.Optimized = true;
variable.SetFieldName("ordermainid_c");
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssSTRegionId; else variable.Optimized = true;
variable.SetFieldName("regionid");
} else if (head == "regionid_c") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId_c")) variable.Value = ssSTRegionId_c; else variable.Optimized = true;
variable.SetFieldName("regionid_c");
} else if (head == "currencyid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId")) variable.Value = ssSTCurrencyId; else variable.Optimized = true;
variable.SetFieldName("currencyid");
} else if (head == "currencyid_c") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CurrencyId_c")) variable.Value = ssSTCurrencyId_c; else variable.Optimized = true;
variable.SetFieldName("currencyid_c");
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
if (key == IdCompanyId) {
return ssSTCompanyId;
}
if (key == IdCompanyId_c) {
return ssSTCompanyId_c;
}
if (key == IdDocumentTypeId) {
return ssSTDocumentTypeId;
}
if (key == IdDocumentTypeId_c) {
return ssSTDocumentTypeId_c;
}
if (key == IdOrderMainId) {
return ssSTOrderMainId;
}
if (key == IdOrderMainId_c) {
return ssSTOrderMainId_c;
}
if (key == IdRegionId) {
return ssSTRegionId;
}
if (key == IdRegionId_c) {
return ssSTRegionId_c;
}
if (key == IdCurrencyId) {
return ssSTCurrencyId;
}
if (key == IdCurrencyId_c) {
return ssSTCurrencyId_c;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCompanyId.Key.AsGuid) {
return ssSTCompanyId;
}
if (attributeKey == IdCompanyId_c.Key.AsGuid) {
return ssSTCompanyId_c;
}
if (attributeKey == IdDocumentTypeId.Key.AsGuid) {
return ssSTDocumentTypeId;
}
if (attributeKey == IdDocumentTypeId_c.Key.AsGuid) {
return ssSTDocumentTypeId_c;
}
if (attributeKey == IdOrderMainId.Key.AsGuid) {
return ssSTOrderMainId;
}
if (attributeKey == IdOrderMainId_c.Key.AsGuid) {
return ssSTOrderMainId_c;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssSTRegionId;
}
if (attributeKey == IdRegionId_c.Key.AsGuid) {
return ssSTRegionId_c;
}
if (attributeKey == IdCurrencyId.Key.AsGuid) {
return ssSTCurrencyId;
}
if (attributeKey == IdCurrencyId_c.Key.AsGuid) {
return ssSTCurrencyId_c;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCompanyId.FillFromOther((IRecord) other.AttributeGet(IdCompanyId));
ssSTCompanyId_c.FillFromOther((IRecord) other.AttributeGet(IdCompanyId_c));
ssSTDocumentTypeId.FillFromOther((IRecord) other.AttributeGet(IdDocumentTypeId));
ssSTDocumentTypeId_c.FillFromOther((IRecord) other.AttributeGet(IdDocumentTypeId_c));
ssSTOrderMainId.FillFromOther((IRecord) other.AttributeGet(IdOrderMainId));
ssSTOrderMainId_c.FillFromOther((IRecord) other.AttributeGet(IdOrderMainId_c));
ssSTRegionId.FillFromOther((IRecord) other.AttributeGet(IdRegionId));
ssSTRegionId_c.FillFromOther((IRecord) other.AttributeGet(IdRegionId_c));
ssSTCurrencyId.FillFromOther((IRecord) other.AttributeGet(IdCurrencyId));
ssSTCurrencyId_c.FillFromOther((IRecord) other.AttributeGet(IdCurrencyId_c));
}
} // RC_f8d32413a09252891cf320a9f349aadb
/// <summary>
/// RecordList type
///  <code>CompanyIdCompanyId_cDocumentTypeIdDocumentTypeId_cOrderMainIdOrderMainId_cRegionIdRegionId_cC
/// urrencyIdCurrencyId_cRecordList</code> that represents a record list of
///  <code>LongIntegerIdentifier, LongIntegerIdentifier, LongIntegerIdentifier, LongIntegerIdentifier
/// , LongIntegerIdentifier, LongIntegerIdentifier, LongIntegerIdentifier, LongIntegerIdentifier, Text,
///  Text</code>
/// </summary>
public partial class RL_d369b356f77fe3a0c5803a2290f0d56b : GenericRecordList<RC_f8d32413a09252891cf320a9f349aadb>, IEnumerable, IEnumerator {

protected override RC_f8d32413a09252891cf320a9f349aadb GetElementDefaultValue() {
return new RC_f8d32413a09252891cf320a9f349aadb();
}

public T[] ToArray<T>(Func<RC_f8d32413a09252891cf320a9f349aadb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d369b356f77fe3a0c5803a2290f0d56b recordList, Func<RC_f8d32413a09252891cf320a9f349aadb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d369b356f77fe3a0c5803a2290f0d56b(RC_f8d32413a09252891cf320a9f349aadb[] array) {
  RL_d369b356f77fe3a0c5803a2290f0d56b result = new RL_d369b356f77fe3a0c5803a2290f0d56b();
result.InnerFromArray(array);
    return result;
}

public static RL_d369b356f77fe3a0c5803a2290f0d56b ToList<T>(T[] array, Func <T, RC_f8d32413a09252891cf320a9f349aadb> converter) {
  RL_d369b356f77fe3a0c5803a2290f0d56b result = new RL_d369b356f77fe3a0c5803a2290f0d56b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d369b356f77fe3a0c5803a2290f0d56b FromRestList<T>(RestList<T> restList, Func <T, RC_f8d32413a09252891cf320a9f349aadb> converter) {
  RL_d369b356f77fe3a0c5803a2290f0d56b result = new RL_d369b356f77fe3a0c5803a2290f0d56b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d369b356f77fe3a0c5803a2290f0d56b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[10];
def[0] = null;
def[1] = null;
def[2] = null;
def[3] = null;
def[4] = null;
def[5] = null;
def[6] = null;
def[7] = null;
def[8] = null;
def[9] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f8d32413a09252891cf320a9f349aadb> NewList() {
return new RL_d369b356f77fe3a0c5803a2290f0d56b();
}


} // RL_d369b356f77fe3a0c5803a2290f0d56b
}

