namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (GRk3GigJk0CRdPq38Yrj+Q)
///  <code>RC_8b7c923e868586b85592884287e2136d</code> that represent
/// s <code>RequisitionSupplierCostCenterSAPFrequencyProject_Asset_ServiceRegionRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: RequisitionSupplierCostCenterSAPFrequencyProject_Asset_ServiceRegionRecord
public partial struct RC_8b7c923e868586b85592884287e2136d : ITypedRecord<RC_8b7c923e868586b85592884287e2136d> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");
internal static readonly GlobalObjectKey IdFrequency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2AnG8vhYHkF1++3uYMXd3w");
internal static readonly GlobalObjectKey IdProject_Asset_Service = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*waIIG87O4_GzAGpguX_Gjg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;

public EN_a6239c65aa61ed4530d18a92034301bbEntityRecord ssENFrequency;

public EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord ssENProject_Asset_Service;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_8b7c923e868586b85592884287e2136d() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
ssENFrequency = new EN_a6239c65aa61ed4530d18a92034301bbEntityRecord();
ssENProject_Asset_Service = new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(28,false);
    all[2] = new BitArray(25,false);
    all[3] = new BitArray(4,false);
    all[4] = new BitArray(7,false);
    all[5] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFrequency.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENProject_Asset_Service.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENSupplier.OptimizedAttributes = value[1];
    ssENCostCenterSAP.OptimizedAttributes = value[2];
    ssENFrequency.OptimizedAttributes = value[3];
    ssENProject_Asset_Service.OptimizedAttributes = value[4];
    ssENRegion.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENRequisition.OptimizedAttributes;
    all[1] = ssENSupplier.OptimizedAttributes;
    all[2] = ssENCostCenterSAP.OptimizedAttributes;
    all[3] = ssENFrequency.OptimizedAttributes;
    all[4] = ssENProject_Asset_Service.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENCostCenterSAP.Read( r, ref index);
ssENFrequency.Read( r, ref index);
ssENProject_Asset_Service.Read( r, ref index);
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
public void ReadIM(RC_8b7c923e868586b85592884287e2136d r) {
this = r;
}


public static bool operator == (RC_8b7c923e868586b85592884287e2136d a, RC_8b7c923e868586b85592884287e2136d b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
if (a.ssENFrequency != b.ssENFrequency) return false;
if (a.ssENProject_Asset_Service != b.ssENProject_Asset_Service) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_8b7c923e868586b85592884287e2136d a, RC_8b7c923e868586b85592884287e2136d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_8b7c923e868586b85592884287e2136d)) return false;
return (this == (RC_8b7c923e868586b85592884287e2136d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
 ^ ssENFrequency.GetHashCode()
 ^ ssENProject_Asset_Service.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
ssENFrequency.RecursiveReset();
ssENProject_Asset_Service.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
ssENFrequency.InternalRecursiveSave();
ssENProject_Asset_Service.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_8b7c923e868586b85592884287e2136d Duplicate() {
RC_8b7c923e868586b85592884287e2136d t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENCostCenterSAP = (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord)this.ssENCostCenterSAP.Duplicate();
t.ssENFrequency = (EN_a6239c65aa61ed4530d18a92034301bbEntityRecord)this.ssENFrequency.Duplicate();
t.ssENProject_Asset_Service = (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord)this.ssENProject_Asset_Service.Duplicate();
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
if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "costcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterSAP")) variable.Value = ssENCostCenterSAP; else variable.Optimized = true;
variable.SetFieldName("costcentersap");
} else if (head == "frequency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Frequency")) variable.Value = ssENFrequency; else variable.Optimized = true;
variable.SetFieldName("frequency");
} else if (head == "project_asset_service") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project_Asset_Service")) variable.Value = ssENProject_Asset_Service; else variable.Optimized = true;
variable.SetFieldName("project_asset_service");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdCostCenterSAP) {
return ssENCostCenterSAP;
}
if (key == IdFrequency) {
return ssENFrequency;
}
if (key == IdProject_Asset_Service) {
return ssENProject_Asset_Service;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdCostCenterSAP.Key.AsGuid) {
return ssENCostCenterSAP;
}
if (attributeKey == IdFrequency.Key.AsGuid) {
return ssENFrequency;
}
if (attributeKey == IdProject_Asset_Service.Key.AsGuid) {
return ssENProject_Asset_Service;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
ssENFrequency.FillFromOther((IRecord) other.AttributeGet(IdFrequency));
ssENProject_Asset_Service.FillFromOther((IRecord) other.AttributeGet(IdProject_Asset_Service));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_8b7c923e868586b85592884287e2136d
/// <summary>
/// RecordList type
///  <code>RequisitionSupplierCostCenterSAPFrequencyProject_Asset_ServiceRegionRecordList</code> tha
/// t represents a record list of <code>Requisition, Supplier, CostCenterSAP, Frequency,
///  Project_Asset_Service, Region</code>
/// </summary>
public partial class RL_ec7fd70758abaa586e4d3f90d8e7ea59 : GenericRecordList<RC_8b7c923e868586b85592884287e2136d>, IEnumerable, IEnumerator {

protected override RC_8b7c923e868586b85592884287e2136d GetElementDefaultValue() {
return new RC_8b7c923e868586b85592884287e2136d();
}

public T[] ToArray<T>(Func<RC_8b7c923e868586b85592884287e2136d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ec7fd70758abaa586e4d3f90d8e7ea59 recordList, Func<RC_8b7c923e868586b85592884287e2136d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ec7fd70758abaa586e4d3f90d8e7ea59(RC_8b7c923e868586b85592884287e2136d[] array) {
  RL_ec7fd70758abaa586e4d3f90d8e7ea59 result = new RL_ec7fd70758abaa586e4d3f90d8e7ea59();
result.InnerFromArray(array);
    return result;
}

public static RL_ec7fd70758abaa586e4d3f90d8e7ea59 ToList<T>(T[] array, Func <T, RC_8b7c923e868586b85592884287e2136d> converter) {
  RL_ec7fd70758abaa586e4d3f90d8e7ea59 result = new RL_ec7fd70758abaa586e4d3f90d8e7ea59();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ec7fd70758abaa586e4d3f90d8e7ea59 FromRestList<T>(RestList<T> restList, Func <T, RC_8b7c923e868586b85592884287e2136d> converter) {
  RL_ec7fd70758abaa586e4d3f90d8e7ea59 result = new RL_ec7fd70758abaa586e4d3f90d8e7ea59();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ec7fd70758abaa586e4d3f90d8e7ea59() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(58,false);
def[1] = new BitArray(28,false);
def[2] = new BitArray(25,false);
def[3] = new BitArray(4,false);
def[4] = new BitArray(7,false);
def[5] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_8b7c923e868586b85592884287e2136d> NewList() {
return new RL_ec7fd70758abaa586e4d3f90d8e7ea59();
}


} // RL_ec7fd70758abaa586e4d3f90d8e7ea59
}

