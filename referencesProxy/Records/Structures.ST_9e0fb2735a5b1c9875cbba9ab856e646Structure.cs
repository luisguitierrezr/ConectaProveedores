namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TI_RETENCIONES_Out (u8zAxvFelE26mr1kepSs4g)
///  <code>ST_9e0fb2735a5b1c9875cbba9ab856e646Structure</code> that represent
/// s <code>TI_RETENCIONES_Out</code> <p>Description: </p>
/// </summary>
// Name: TI_RETENCIONES_Out
public partial struct ST_9e0fb2735a5b1c9875cbba9ab856e646Structure : ITypedRecord<ST_9e0fb2735a5b1c9875cbba9ab856e646Structure> {
internal static readonly GlobalObjectKey IdLIFNR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Ef8Vi6ZOYkORh4bwhAF_dA");
internal static readonly GlobalObjectKey IdBUKRS = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*0gmvPlJxAkeB_y9dNPA6tg");
internal static readonly GlobalObjectKey IdWITHT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*xBAs3T+MzkW5WCphniHfDw");
internal static readonly GlobalObjectKey IdWT_WITHCD = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*MSCOgG57bUSo1yLO23q1fw");
internal static readonly GlobalObjectKey IdWT_SUBJCT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*PjVFwDdcO0akkHAmJDn2Tw");

public string ssLIFNR;

public string ssBUKRS;

public string ssWITHT;

public string ssWT_WITHCD;

public string ssWT_SUBJCT;


public BitArray OptimizedAttributes;

public ST_9e0fb2735a5b1c9875cbba9ab856e646Structure() {
OptimizedAttributes = null;
ssLIFNR = "";
ssBUKRS = "";
ssWITHT = "";
ssWT_WITHCD = "";
ssWT_SUBJCT = "";
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
ssLIFNR = r.ReadText(index++, "TI_RETENCIONES_Out.LIFNR", "");
ssBUKRS = r.ReadText(index++, "TI_RETENCIONES_Out.BUKRS", "");
ssWITHT = r.ReadText(index++, "TI_RETENCIONES_Out.WITHT", "");
ssWT_WITHCD = r.ReadText(index++, "TI_RETENCIONES_Out.WT_WITHCD", "");
ssWT_SUBJCT = r.ReadText(index++, "TI_RETENCIONES_Out.WT_SUBJCT", "");
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
public void ReadIM(ST_9e0fb2735a5b1c9875cbba9ab856e646Structure r) {
this = r;
}


public static bool operator == (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure a, ST_9e0fb2735a5b1c9875cbba9ab856e646Structure b) {
if (a.ssLIFNR != b.ssLIFNR) return false;
if (a.ssBUKRS != b.ssBUKRS) return false;
if (a.ssWITHT != b.ssWITHT) return false;
if (a.ssWT_WITHCD != b.ssWT_WITHCD) return false;
if (a.ssWT_SUBJCT != b.ssWT_SUBJCT) return false;
return true;
}

public static bool operator != (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure a, ST_9e0fb2735a5b1c9875cbba9ab856e646Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure)) return false;
return (this == (ST_9e0fb2735a5b1c9875cbba9ab856e646Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssLIFNR.GetHashCode()
 ^ ssBUKRS.GetHashCode()
 ^ ssWITHT.GetHashCode()
 ^ ssWT_WITHCD.GetHashCode()
 ^ ssWT_SUBJCT.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_9e0fb2735a5b1c9875cbba9ab856e646Structure Duplicate() {
ST_9e0fb2735a5b1c9875cbba9ab856e646Structure t;
t.ssLIFNR = this.ssLIFNR;
t.ssBUKRS = this.ssBUKRS;
t.ssWITHT = this.ssWITHT;
t.ssWT_WITHCD = this.ssWT_WITHCD;
t.ssWT_SUBJCT = this.ssWT_SUBJCT;
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
if (head == "lifnr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LIFNR")) variable.Value = ssLIFNR; else variable.Optimized = true;
} else if (head == "bukrs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BUKRS")) variable.Value = ssBUKRS; else variable.Optimized = true;
} else if (head == "witht") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WITHT")) variable.Value = ssWITHT; else variable.Optimized = true;
} else if (head == "wt_withcd") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WT_WITHCD")) variable.Value = ssWT_WITHCD; else variable.Optimized = true;
} else if (head == "wt_subjct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WT_SUBJCT")) variable.Value = ssWT_SUBJCT; else variable.Optimized = true;
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
if (key == IdLIFNR) {
return ssLIFNR;
}
if (key == IdBUKRS) {
return ssBUKRS;
}
if (key == IdWITHT) {
return ssWITHT;
}
if (key == IdWT_WITHCD) {
return ssWT_WITHCD;
}
if (key == IdWT_SUBJCT) {
return ssWT_SUBJCT;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLIFNR.Key.AsGuid) {
return ssLIFNR;
}
if (attributeKey == IdBUKRS.Key.AsGuid) {
return ssBUKRS;
}
if (attributeKey == IdWITHT.Key.AsGuid) {
return ssWITHT;
}
if (attributeKey == IdWT_WITHCD.Key.AsGuid) {
return ssWT_WITHCD;
}
if (attributeKey == IdWT_SUBJCT.Key.AsGuid) {
return ssWT_SUBJCT;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssLIFNR = (string) other.AttributeGet(IdLIFNR);
ssBUKRS = (string) other.AttributeGet(IdBUKRS);
ssWITHT = (string) other.AttributeGet(IdWITHT);
ssWT_WITHCD = (string) other.AttributeGet(IdWT_WITHCD);
ssWT_SUBJCT = (string) other.AttributeGet(IdWT_SUBJCT);
}
} // ST_9e0fb2735a5b1c9875cbba9ab856e646Structure
/// <summary>
/// RecordList type <code>TI_RETENCIONES_OutList</code> that represents a record list of
///  <code>TI_RETENCIONES_Out</code>
/// </summary>
public partial class RL_4b72a47efbb84d37cf5e3e0ffb46314d : GenericRecordList<ST_9e0fb2735a5b1c9875cbba9ab856e646Structure>, IEnumerable, IEnumerator {

protected override ST_9e0fb2735a5b1c9875cbba9ab856e646Structure GetElementDefaultValue() {
return new ST_9e0fb2735a5b1c9875cbba9ab856e646Structure();
}

public T[] ToArray<T>(Func<ST_9e0fb2735a5b1c9875cbba9ab856e646Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4b72a47efbb84d37cf5e3e0ffb46314d recordList, Func<ST_9e0fb2735a5b1c9875cbba9ab856e646Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4b72a47efbb84d37cf5e3e0ffb46314d(ST_9e0fb2735a5b1c9875cbba9ab856e646Structure[] array) {
  RL_4b72a47efbb84d37cf5e3e0ffb46314d result = new RL_4b72a47efbb84d37cf5e3e0ffb46314d();
result.InnerFromArray(array);
    return result;
}

public static RL_4b72a47efbb84d37cf5e3e0ffb46314d ToList<T>(T[] array, Func <T, ST_9e0fb2735a5b1c9875cbba9ab856e646Structure> converter) {
  RL_4b72a47efbb84d37cf5e3e0ffb46314d result = new RL_4b72a47efbb84d37cf5e3e0ffb46314d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4b72a47efbb84d37cf5e3e0ffb46314d FromRestList<T>(RestList<T> restList, Func <T, ST_9e0fb2735a5b1c9875cbba9ab856e646Structure> converter) {
  RL_4b72a47efbb84d37cf5e3e0ffb46314d result = new RL_4b72a47efbb84d37cf5e3e0ffb46314d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4b72a47efbb84d37cf5e3e0ffb46314d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_9e0fb2735a5b1c9875cbba9ab856e646Structure> NewList() {
return new RL_4b72a47efbb84d37cf5e3e0ffb46314d();
}


} // RL_4b72a47efbb84d37cf5e3e0ffb46314d
}

