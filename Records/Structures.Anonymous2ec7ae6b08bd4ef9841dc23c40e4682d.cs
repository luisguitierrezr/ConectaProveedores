namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (a67HLr0I+U6EHcI8QORoLQ)
///  <code>RC_4d57f99d5ffffde65e439e566311a35e</code> that represent
/// s <code>CompanyIdDocumentTypeIdRegionIdRecord</code> <p>Description: </p>
/// </summary>
// Name: CompanyIdDocumentTypeIdRegionIdRecord
public partial struct RC_4d57f99d5ffffde65e439e566311a35e : ITypedRecord<RC_4d57f99d5ffffde65e439e566311a35e> {
internal static readonly GlobalObjectKey IdCompanyId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yVxTYk1gZtvVQfiJedHZbQ");
internal static readonly GlobalObjectKey IdDocumentTypeId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OZ2YhwrkjwaWI2zdS_iDxg");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gcEzGObtOtm5olUL8jFgfA");

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTCompanyId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTDocumentTypeId;

public ST_52a0b4b2bb66d62c40848f2d472a3986Structure ssSTRegionId;


public BitArray OptimizedAttributes;

public RC_4d57f99d5ffffde65e439e566311a35e() {
OptimizedAttributes = null;
ssSTCompanyId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTDocumentTypeId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
ssSTRegionId = new ST_52a0b4b2bb66d62c40848f2d472a3986Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = null;
    all[1] = null;
    all[2] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTCompanyId.OptimizedAttributes = value[0];
    ssSTDocumentTypeId.OptimizedAttributes = value[1];
    ssSTRegionId.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = null;
    all[1] = null;
    all[2] = null;
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
ssSTDocumentTypeId.Read( r, ref index);
ssSTRegionId.Read( r, ref index);
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
public void ReadIM(RC_4d57f99d5ffffde65e439e566311a35e r) {
this = r;
}


public static bool operator == (RC_4d57f99d5ffffde65e439e566311a35e a, RC_4d57f99d5ffffde65e439e566311a35e b) {
if (a.ssSTCompanyId != b.ssSTCompanyId) return false;
if (a.ssSTDocumentTypeId != b.ssSTDocumentTypeId) return false;
if (a.ssSTRegionId != b.ssSTRegionId) return false;
return true;
}

public static bool operator != (RC_4d57f99d5ffffde65e439e566311a35e a, RC_4d57f99d5ffffde65e439e566311a35e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4d57f99d5ffffde65e439e566311a35e)) return false;
return (this == (RC_4d57f99d5ffffde65e439e566311a35e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTCompanyId.GetHashCode()
 ^ ssSTDocumentTypeId.GetHashCode()
 ^ ssSTRegionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTCompanyId.RecursiveReset();
ssSTDocumentTypeId.RecursiveReset();
ssSTRegionId.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTCompanyId.InternalRecursiveSave();
ssSTDocumentTypeId.InternalRecursiveSave();
ssSTRegionId.InternalRecursiveSave();
}


public RC_4d57f99d5ffffde65e439e566311a35e Duplicate() {
RC_4d57f99d5ffffde65e439e566311a35e t;
t.ssSTCompanyId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTCompanyId.Duplicate();
t.ssSTDocumentTypeId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTDocumentTypeId.Duplicate();
t.ssSTRegionId = (ST_52a0b4b2bb66d62c40848f2d472a3986Structure)this.ssSTRegionId.Duplicate();
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
} else if (head == "documenttypeid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentTypeId")) variable.Value = ssSTDocumentTypeId; else variable.Optimized = true;
variable.SetFieldName("documenttypeid");
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssSTRegionId; else variable.Optimized = true;
variable.SetFieldName("regionid");
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
if (key == IdDocumentTypeId) {
return ssSTDocumentTypeId;
}
if (key == IdRegionId) {
return ssSTRegionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCompanyId.Key.AsGuid) {
return ssSTCompanyId;
}
if (attributeKey == IdDocumentTypeId.Key.AsGuid) {
return ssSTDocumentTypeId;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssSTRegionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTCompanyId.FillFromOther((IRecord) other.AttributeGet(IdCompanyId));
ssSTDocumentTypeId.FillFromOther((IRecord) other.AttributeGet(IdDocumentTypeId));
ssSTRegionId.FillFromOther((IRecord) other.AttributeGet(IdRegionId));
}
} // RC_4d57f99d5ffffde65e439e566311a35e
/// <summary>
/// RecordList type <code>CompanyIdDocumentTypeIdRegionIdRecordList</code> that represents a record
///  list of <code>LongIntegerIdentifier, LongIntegerIdentifier, LongIntegerIdentifier</code>
/// </summary>
public partial class RL_a90e7a0b0a356de6b75df3eee56614eb : GenericRecordList<RC_4d57f99d5ffffde65e439e566311a35e>, IEnumerable, IEnumerator {

protected override RC_4d57f99d5ffffde65e439e566311a35e GetElementDefaultValue() {
return new RC_4d57f99d5ffffde65e439e566311a35e();
}

public T[] ToArray<T>(Func<RC_4d57f99d5ffffde65e439e566311a35e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a90e7a0b0a356de6b75df3eee56614eb recordList, Func<RC_4d57f99d5ffffde65e439e566311a35e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a90e7a0b0a356de6b75df3eee56614eb(RC_4d57f99d5ffffde65e439e566311a35e[] array) {
  RL_a90e7a0b0a356de6b75df3eee56614eb result = new RL_a90e7a0b0a356de6b75df3eee56614eb();
result.InnerFromArray(array);
    return result;
}

public static RL_a90e7a0b0a356de6b75df3eee56614eb ToList<T>(T[] array, Func <T, RC_4d57f99d5ffffde65e439e566311a35e> converter) {
  RL_a90e7a0b0a356de6b75df3eee56614eb result = new RL_a90e7a0b0a356de6b75df3eee56614eb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a90e7a0b0a356de6b75df3eee56614eb FromRestList<T>(RestList<T> restList, Func <T, RC_4d57f99d5ffffde65e439e566311a35e> converter) {
  RL_a90e7a0b0a356de6b75df3eee56614eb result = new RL_a90e7a0b0a356de6b75df3eee56614eb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a90e7a0b0a356de6b75df3eee56614eb() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = null;
def[1] = null;
def[2] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_4d57f99d5ffffde65e439e566311a35e> NewList() {
return new RL_a90e7a0b0a356de6b75df3eee56614eb();
}


} // RL_a90e7a0b0a356de6b75df3eee56614eb
}

