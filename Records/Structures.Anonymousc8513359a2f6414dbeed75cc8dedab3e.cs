namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (WTNRyPaiTUG+7XXMje2rPg)
///  <code>RC_8e32b78ccc2e260e65e10c5d6c59046d</code> that represent
/// s <code>OrderStatusOrderMainDocumentTypeCompanySupplierTelcelDirectionRegionRegion_2Record</code>
///  <p>Description: </p>
/// </summary>
// Name: OrderStatusOrderMainDocumentTypeCompanySupplierTelcelDirectionRegionRegion_2Record
public partial struct RC_8e32b78ccc2e260e65e10c5d6c59046d : ITypedRecord<RC_8e32b78ccc2e260e65e10c5d6c59046d> {
internal static readonly GlobalObjectKey IdOrderStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3HKdkZJSEuhZevT6wKgI5A");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdDocumentType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1AT3EIne4plVoJ9rG5tWaA");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GJPF90MHwEDiMLq9XqYvtQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");
internal static readonly GlobalObjectKey IdRegion_2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*MChok_kgfd9NGw39UjbjOg");

public EN_5eda60810da752f579e01795bb7e0de0EntityRecord ssENOrderStatus;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_a70d553ce1458b3952d039852f258a76EntityRecord ssENDocumentType;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord ssENTelcelDirection;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion_2;


public BitArray OptimizedAttributes;

public RC_8e32b78ccc2e260e65e10c5d6c59046d() {
OptimizedAttributes = null;
ssENOrderStatus = new EN_5eda60810da752f579e01795bb7e0de0EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENDocumentType = new EN_a70d553ce1458b3952d039852f258a76EntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENTelcelDirection = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
ssENRegion_2 = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(6,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(11,false);
    all[4] = new BitArray(28,false);
    all[5] = new BitArray(7,false);
    all[6] = new BitArray(13,false);
    all[7] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENDocumentType.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENRegion_2.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENOrderStatus.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENDocumentType.OptimizedAttributes = value[2];
    ssENCompany.OptimizedAttributes = value[3];
    ssENSupplier.OptimizedAttributes = value[4];
    ssENTelcelDirection.OptimizedAttributes = value[5];
    ssENRegion.OptimizedAttributes = value[6];
    ssENRegion_2.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENOrderStatus.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENDocumentType.OptimizedAttributes;
    all[3] = ssENCompany.OptimizedAttributes;
    all[4] = ssENSupplier.OptimizedAttributes;
    all[5] = ssENTelcelDirection.OptimizedAttributes;
    all[6] = ssENRegion.OptimizedAttributes;
    all[7] = ssENRegion_2.OptimizedAttributes;
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
ssENOrderMain.Read( r, ref index);
ssENDocumentType.Read( r, ref index);
ssENCompany.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENTelcelDirection.Read( r, ref index);
ssENRegion.Read( r, ref index);
ssENRegion_2.Read( r, ref index);
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
public void ReadIM(RC_8e32b78ccc2e260e65e10c5d6c59046d r) {
this = r;
}


public static bool operator == (RC_8e32b78ccc2e260e65e10c5d6c59046d a, RC_8e32b78ccc2e260e65e10c5d6c59046d b) {
if (a.ssENOrderStatus != b.ssENOrderStatus) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENDocumentType != b.ssENDocumentType) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENTelcelDirection != b.ssENTelcelDirection) return false;
if (a.ssENRegion != b.ssENRegion) return false;
if (a.ssENRegion_2 != b.ssENRegion_2) return false;
return true;
}

public static bool operator != (RC_8e32b78ccc2e260e65e10c5d6c59046d a, RC_8e32b78ccc2e260e65e10c5d6c59046d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8e32b78ccc2e260e65e10c5d6c59046d)) return false;
return (this == (RC_8e32b78ccc2e260e65e10c5d6c59046d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderStatus.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENDocumentType.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENTelcelDirection.GetHashCode()
 ^ ssENRegion.GetHashCode()
 ^ ssENRegion_2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderStatus.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENDocumentType.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENTelcelDirection.RecursiveReset();
ssENRegion.RecursiveReset();
ssENRegion_2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderStatus.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENDocumentType.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENTelcelDirection.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
ssENRegion_2.InternalRecursiveSave();
}


public RC_8e32b78ccc2e260e65e10c5d6c59046d Duplicate() {
RC_8e32b78ccc2e260e65e10c5d6c59046d t;
t.ssENOrderStatus = (EN_5eda60810da752f579e01795bb7e0de0EntityRecord)this.ssENOrderStatus.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENDocumentType = (EN_a70d553ce1458b3952d039852f258a76EntityRecord)this.ssENDocumentType.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENTelcelDirection = (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord)this.ssENTelcelDirection.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
t.ssENRegion_2 = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion_2.Duplicate();
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
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "documenttype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentType")) variable.Value = ssENDocumentType; else variable.Optimized = true;
variable.SetFieldName("documenttype");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssENTelcelDirection; else variable.Optimized = true;
variable.SetFieldName("telceldirection");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
} else if (head == "region_2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region_2")) variable.Value = ssENRegion_2; else variable.Optimized = true;
variable.SetFieldName("region_2");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdDocumentType) {
return ssENDocumentType;
}
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdTelcelDirection) {
return ssENTelcelDirection;
}
if (key == IdRegion) {
return ssENRegion;
}
if (key == IdRegion_2) {
return ssENRegion_2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderStatus.Key.AsGuid) {
return ssENOrderStatus;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdDocumentType.Key.AsGuid) {
return ssENDocumentType;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssENTelcelDirection;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
if (attributeKey == IdRegion_2.Key.AsGuid) {
return ssENRegion_2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderStatus));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENDocumentType.FillFromOther((IRecord) other.AttributeGet(IdDocumentType));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdTelcelDirection));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
ssENRegion_2.FillFromOther((IRecord) other.AttributeGet(IdRegion_2));
}
} // RC_8e32b78ccc2e260e65e10c5d6c59046d
/// <summary>
/// RecordList type
///  <code>OrderStatusOrderMainDocumentTypeCompanySupplierTelcelDirectionRegionRegion_2RecordList</code
/// > that represents a record list of <code>OrderStatus, OrderMain, DocumentType, Company, Supplier,
///  TelcelDirection, Region, Region</code>
/// </summary>
public partial class RL_1751b6fc487a87e5015dd52d099b7396 : GenericRecordList<RC_8e32b78ccc2e260e65e10c5d6c59046d>, IEnumerable, IEnumerator {

protected override RC_8e32b78ccc2e260e65e10c5d6c59046d GetElementDefaultValue() {
return new RC_8e32b78ccc2e260e65e10c5d6c59046d();
}

public T[] ToArray<T>(Func<RC_8e32b78ccc2e260e65e10c5d6c59046d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1751b6fc487a87e5015dd52d099b7396 recordList, Func<RC_8e32b78ccc2e260e65e10c5d6c59046d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1751b6fc487a87e5015dd52d099b7396(RC_8e32b78ccc2e260e65e10c5d6c59046d[] array) {
  RL_1751b6fc487a87e5015dd52d099b7396 result = new RL_1751b6fc487a87e5015dd52d099b7396();
result.InnerFromArray(array);
    return result;
}

public static RL_1751b6fc487a87e5015dd52d099b7396 ToList<T>(T[] array, Func <T, RC_8e32b78ccc2e260e65e10c5d6c59046d> converter) {
  RL_1751b6fc487a87e5015dd52d099b7396 result = new RL_1751b6fc487a87e5015dd52d099b7396();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1751b6fc487a87e5015dd52d099b7396 FromRestList<T>(RestList<T> restList, Func <T, RC_8e32b78ccc2e260e65e10c5d6c59046d> converter) {
  RL_1751b6fc487a87e5015dd52d099b7396 result = new RL_1751b6fc487a87e5015dd52d099b7396();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1751b6fc487a87e5015dd52d099b7396() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(6,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(11,false);
def[4] = new BitArray(28,false);
def[5] = new BitArray(7,false);
def[6] = new BitArray(13,false);
def[7] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8e32b78ccc2e260e65e10c5d6c59046d> NewList() {
return new RL_1751b6fc487a87e5015dd52d099b7396();
}


} // RL_1751b6fc487a87e5015dd52d099b7396
}

