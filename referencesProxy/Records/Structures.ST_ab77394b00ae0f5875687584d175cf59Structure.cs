namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] ItemSM (IxFC78e7dUChvkVUot7DUg)
///  <code>ST_ab77394b00ae0f5875687584d175cf59Structure</code> that represents <code>ItemSM</code
/// > <p>Description: ItemSM</p>
/// </summary>
// Name: ItemSM
public partial struct ST_ab77394b00ae0f5875687584d175cf59Structure : ITypedRecord<ST_ab77394b00ae0f5875687584d175cf59Structure> {
internal static readonly GlobalObjectKey IdPOSICION_PEDIDO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*_35aoIMMnky+vdjvfscRtg");
internal static readonly GlobalObjectKey IdMATERIAL = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*yIGUzMrcrEyHAdBGnA_cDg");
internal static readonly GlobalObjectKey IdCANTIDAD_SALIDA = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*LxOIOVY4J0qIoZ5TfrN0lw");
internal static readonly GlobalObjectKey IdCENTRO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*VZ2MMA+vUUa2EfS02LdavQ");
internal static readonly GlobalObjectKey IdALMACEN = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*iHfuKhT8H028fX7LwrGejQ");
internal static readonly GlobalObjectKey IdTEXTO_POSICION = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*jCIEmXhEkE++K1sEdU+s2w");
internal static readonly GlobalObjectKey IdCUENTA_DE_MAYOR = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*BngxzZ327EaVgx+qZP+DLA");
internal static readonly GlobalObjectKey IdCENTRO_DE_COSTO = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*wcLbqg6c2U+KIUaax1+3lg");

public string ssPOSICION_PEDIDO;

public string ssMATERIAL;

public string ssCANTIDAD_SALIDA;

public string ssCENTRO;

public string ssALMACEN;

public string ssTEXTO_POSICION;

public string ssCUENTA_DE_MAYOR;

public string ssCENTRO_DE_COSTO;


public BitArray OptimizedAttributes;

public ST_ab77394b00ae0f5875687584d175cf59Structure() {
OptimizedAttributes = null;
ssPOSICION_PEDIDO = "";
ssMATERIAL = "";
ssCANTIDAD_SALIDA = "";
ssCENTRO = "";
ssALMACEN = "";
ssTEXTO_POSICION = "";
ssCUENTA_DE_MAYOR = "";
ssCENTRO_DE_COSTO = "";
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
ssPOSICION_PEDIDO = r.ReadText(index++, "ItemSM.POSICION_PEDIDO", "");
ssMATERIAL = r.ReadText(index++, "ItemSM.MATERIAL", "");
ssCANTIDAD_SALIDA = r.ReadText(index++, "ItemSM.CANTIDAD_SALIDA", "");
ssCENTRO = r.ReadText(index++, "ItemSM.CENTRO", "");
ssALMACEN = r.ReadText(index++, "ItemSM.ALMACEN", "");
ssTEXTO_POSICION = r.ReadText(index++, "ItemSM.TEXTO_POSICION", "");
ssCUENTA_DE_MAYOR = r.ReadText(index++, "ItemSM.CUENTA_DE_MAYOR", "");
ssCENTRO_DE_COSTO = r.ReadText(index++, "ItemSM.CENTRO_DE_COSTO", "");
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
public void ReadIM(ST_ab77394b00ae0f5875687584d175cf59Structure r) {
this = r;
}


public static bool operator == (ST_ab77394b00ae0f5875687584d175cf59Structure a, ST_ab77394b00ae0f5875687584d175cf59Structure b) {
if (a.ssPOSICION_PEDIDO != b.ssPOSICION_PEDIDO) return false;
if (a.ssMATERIAL != b.ssMATERIAL) return false;
if (a.ssCANTIDAD_SALIDA != b.ssCANTIDAD_SALIDA) return false;
if (a.ssCENTRO != b.ssCENTRO) return false;
if (a.ssALMACEN != b.ssALMACEN) return false;
if (a.ssTEXTO_POSICION != b.ssTEXTO_POSICION) return false;
if (a.ssCUENTA_DE_MAYOR != b.ssCUENTA_DE_MAYOR) return false;
if (a.ssCENTRO_DE_COSTO != b.ssCENTRO_DE_COSTO) return false;
return true;
}

public static bool operator != (ST_ab77394b00ae0f5875687584d175cf59Structure a, ST_ab77394b00ae0f5875687584d175cf59Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ab77394b00ae0f5875687584d175cf59Structure)) return false;
return (this == (ST_ab77394b00ae0f5875687584d175cf59Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPOSICION_PEDIDO.GetHashCode()
 ^ ssMATERIAL.GetHashCode()
 ^ ssCANTIDAD_SALIDA.GetHashCode()
 ^ ssCENTRO.GetHashCode()
 ^ ssALMACEN.GetHashCode()
 ^ ssTEXTO_POSICION.GetHashCode()
 ^ ssCUENTA_DE_MAYOR.GetHashCode()
 ^ ssCENTRO_DE_COSTO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_ab77394b00ae0f5875687584d175cf59Structure Duplicate() {
ST_ab77394b00ae0f5875687584d175cf59Structure t;
t.ssPOSICION_PEDIDO = this.ssPOSICION_PEDIDO;
t.ssMATERIAL = this.ssMATERIAL;
t.ssCANTIDAD_SALIDA = this.ssCANTIDAD_SALIDA;
t.ssCENTRO = this.ssCENTRO;
t.ssALMACEN = this.ssALMACEN;
t.ssTEXTO_POSICION = this.ssTEXTO_POSICION;
t.ssCUENTA_DE_MAYOR = this.ssCUENTA_DE_MAYOR;
t.ssCENTRO_DE_COSTO = this.ssCENTRO_DE_COSTO;
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
if (head == "posicion_pedido") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".POSICION_PEDIDO")) variable.Value = ssPOSICION_PEDIDO; else variable.Optimized = true;
} else if (head == "material") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MATERIAL")) variable.Value = ssMATERIAL; else variable.Optimized = true;
} else if (head == "cantidad_salida") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CANTIDAD_SALIDA")) variable.Value = ssCANTIDAD_SALIDA; else variable.Optimized = true;
} else if (head == "centro") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CENTRO")) variable.Value = ssCENTRO; else variable.Optimized = true;
} else if (head == "almacen") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ALMACEN")) variable.Value = ssALMACEN; else variable.Optimized = true;
} else if (head == "texto_posicion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TEXTO_POSICION")) variable.Value = ssTEXTO_POSICION; else variable.Optimized = true;
} else if (head == "cuenta_de_mayor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CUENTA_DE_MAYOR")) variable.Value = ssCUENTA_DE_MAYOR; else variable.Optimized = true;
} else if (head == "centro_de_costo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CENTRO_DE_COSTO")) variable.Value = ssCENTRO_DE_COSTO; else variable.Optimized = true;
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
if (key == IdPOSICION_PEDIDO) {
return ssPOSICION_PEDIDO;
}
if (key == IdMATERIAL) {
return ssMATERIAL;
}
if (key == IdCANTIDAD_SALIDA) {
return ssCANTIDAD_SALIDA;
}
if (key == IdCENTRO) {
return ssCENTRO;
}
if (key == IdALMACEN) {
return ssALMACEN;
}
if (key == IdTEXTO_POSICION) {
return ssTEXTO_POSICION;
}
if (key == IdCUENTA_DE_MAYOR) {
return ssCUENTA_DE_MAYOR;
}
if (key == IdCENTRO_DE_COSTO) {
return ssCENTRO_DE_COSTO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPOSICION_PEDIDO.Key.AsGuid) {
return ssPOSICION_PEDIDO;
}
if (attributeKey == IdMATERIAL.Key.AsGuid) {
return ssMATERIAL;
}
if (attributeKey == IdCANTIDAD_SALIDA.Key.AsGuid) {
return ssCANTIDAD_SALIDA;
}
if (attributeKey == IdCENTRO.Key.AsGuid) {
return ssCENTRO;
}
if (attributeKey == IdALMACEN.Key.AsGuid) {
return ssALMACEN;
}
if (attributeKey == IdTEXTO_POSICION.Key.AsGuid) {
return ssTEXTO_POSICION;
}
if (attributeKey == IdCUENTA_DE_MAYOR.Key.AsGuid) {
return ssCUENTA_DE_MAYOR;
}
if (attributeKey == IdCENTRO_DE_COSTO.Key.AsGuid) {
return ssCENTRO_DE_COSTO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPOSICION_PEDIDO = (string) other.AttributeGet(IdPOSICION_PEDIDO);
ssMATERIAL = (string) other.AttributeGet(IdMATERIAL);
ssCANTIDAD_SALIDA = (string) other.AttributeGet(IdCANTIDAD_SALIDA);
ssCENTRO = (string) other.AttributeGet(IdCENTRO);
ssALMACEN = (string) other.AttributeGet(IdALMACEN);
ssTEXTO_POSICION = (string) other.AttributeGet(IdTEXTO_POSICION);
ssCUENTA_DE_MAYOR = (string) other.AttributeGet(IdCUENTA_DE_MAYOR);
ssCENTRO_DE_COSTO = (string) other.AttributeGet(IdCENTRO_DE_COSTO);
}
} // ST_ab77394b00ae0f5875687584d175cf59Structure
/// <summary>
/// RecordList type <code>ItemSMList</code> that represents a record list of <code>ItemSM</code>
/// </summary>
public partial class RL_58f0d660c2772ea329be34fddf4b9ec9 : GenericRecordList<ST_ab77394b00ae0f5875687584d175cf59Structure>, IEnumerable, IEnumerator {

protected override ST_ab77394b00ae0f5875687584d175cf59Structure GetElementDefaultValue() {
return new ST_ab77394b00ae0f5875687584d175cf59Structure();
}

public T[] ToArray<T>(Func<ST_ab77394b00ae0f5875687584d175cf59Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_58f0d660c2772ea329be34fddf4b9ec9 recordList, Func<ST_ab77394b00ae0f5875687584d175cf59Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_58f0d660c2772ea329be34fddf4b9ec9(ST_ab77394b00ae0f5875687584d175cf59Structure[] array) {
  RL_58f0d660c2772ea329be34fddf4b9ec9 result = new RL_58f0d660c2772ea329be34fddf4b9ec9();
result.InnerFromArray(array);
    return result;
}

public static RL_58f0d660c2772ea329be34fddf4b9ec9 ToList<T>(T[] array, Func <T, ST_ab77394b00ae0f5875687584d175cf59Structure> converter) {
  RL_58f0d660c2772ea329be34fddf4b9ec9 result = new RL_58f0d660c2772ea329be34fddf4b9ec9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_58f0d660c2772ea329be34fddf4b9ec9 FromRestList<T>(RestList<T> restList, Func <T, ST_ab77394b00ae0f5875687584d175cf59Structure> converter) {
  RL_58f0d660c2772ea329be34fddf4b9ec9 result = new RL_58f0d660c2772ea329be34fddf4b9ec9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_58f0d660c2772ea329be34fddf4b9ec9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ab77394b00ae0f5875687584d175cf59Structure> NewList() {
return new RL_58f0d660c2772ea329be34fddf4b9ec9();
}


} // RL_58f0d660c2772ea329be34fddf4b9ec9
}

